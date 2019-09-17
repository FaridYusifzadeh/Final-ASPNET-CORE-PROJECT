using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using indecor_web_site.DAL;
using indecor_web_site.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace indecor_web_site
{
    public class Startup
    {

        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<IndecorDbContext>(options => {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);

            });

            services.AddIdentity<AppUser, IdentityRole>(identityoptions => {
                //passwords
                identityoptions.Password.RequireDigit = true;
                identityoptions.Password.RequireLowercase = true;
                identityoptions.Password.RequireUppercase = true;
                identityoptions.Password.RequireNonAlphanumeric = true;
                identityoptions.Password.RequiredLength = 8;

                //unikal email
                identityoptions.User.RequireUniqueEmail = true;

                //users login
                identityoptions.Lockout.MaxFailedAccessAttempts = 3;
                identityoptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(50);
                identityoptions.Lockout.AllowedForNewUsers = true;

            }).AddEntityFrameworkStores<IndecorDbContext>()
              .AddDefaultUI()
              .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
            }); 

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=home}/{action=index}/{id?}"
                    );
            });
           


        }
    }
}

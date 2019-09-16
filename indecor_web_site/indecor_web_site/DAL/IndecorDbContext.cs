using indecor_web_site.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.DAL
{
    public class IndecorDbContext:IdentityDbContext
    {
        public IndecorDbContext(DbContextOptions<IndecorDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<BackgroundImage> BackgroundImages { get; set; }
        public DbSet<AboutMeContext> AboutMeContexts { get; set; }
        public DbSet<SingleBrand> SingleBrands { get; set; }
        public DbSet<FromOurBlog> FromOurBlogs { get; set; }
        public DbSet<SingleFuture> SingleFutures { get; set; }
        public DbSet<Product_Categorie> Product_Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

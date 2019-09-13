using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using indecor_web_site.DAL;
using indecor_web_site.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace indecor_web_site.Controllers
{
    
    public class HomeController : Controller
    {
        private IndecorDbContext _context;

        public HomeController(IndecorDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel
            {
                Sliders=_context.Sliders,
                Descriptions=_context.Descriptions,
                BackgroundImages=_context.BackgroundImages,
                AboutMeContexts=_context.AboutMeContexts,
                SingleBrands=_context.SingleBrands,
                FromOurBlogs=_context.FromOurBlogs,
                SingleFutures=_context.SingleFutures
            };
            return View(homeModel);
        }
    }
}
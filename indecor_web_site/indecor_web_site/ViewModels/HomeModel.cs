using indecor_web_site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
        public IEnumerable<BackgroundImage> BackgroundImages { get; set; }
        public IEnumerable<AboutMeContext> AboutMeContexts { get; set; }
        public IEnumerable<SingleBrand> SingleBrands { get; set; }
        public IEnumerable<FromOurBlog> FromOurBlogs { get; set; }
        public IEnumerable<SingleFuture> SingleFutures { get; set; }
        public IEnumerable<Product_Categorie> Product_Categories { get; set; }
        public IEnumerable<Product> Products{ get; set; }
    }
}

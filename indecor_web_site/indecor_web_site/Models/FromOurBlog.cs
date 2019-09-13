using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.Models
{
    public class FromOurBlog
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, StringLength(100)]
        public string  TitlePost { get; set; }
        [Required, StringLength(100)]
        public string TitleHash { get; set; }
        [Required, StringLength(100)]
        public string TitleDate { get; set; }
        [Required, StringLength(180)]
        public string Image { get; set; }
    }
}

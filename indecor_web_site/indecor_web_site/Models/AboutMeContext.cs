using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.Models
{
    public class AboutMeContext
    {
        public int Id { get; set; }
        [Required,StringLength(250)]
        public string Context { get; set; }
    }
}

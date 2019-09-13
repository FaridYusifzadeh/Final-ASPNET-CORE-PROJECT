using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.Models
{
    public class SingleBrand
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Image { get; set; }
    }
}

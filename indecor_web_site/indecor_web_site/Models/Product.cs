using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(100, ErrorMessage = "The symbol musn't be more 100")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(10, ErrorMessage = "The symbol musn't be more 10")]

        public int Count { get; set; }

        public string Percent { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(10, ErrorMessage = "The symbol musn't be more 10")]

        public double Price { get; set; }

        public double PriceSale { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(100, ErrorMessage = "The symbol musn't be more 100")]

        public string Image { get; set; }

        public string Active { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "The symbol musn't be more 300")]

        public string Description { get; set; }

        public string Datetime { get; set; }

        public bool NEW_ARRIVALS { get; set; }

        public int BEST_SELLER { get; set; }

        public int MOST_VIEW { get; set; }

        public int Product_CategorieId { get; set; }

        public virtual Product_Categorie Product_Categorie { get; set; }

    }
}

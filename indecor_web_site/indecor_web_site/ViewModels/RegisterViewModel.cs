using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indecor_web_site.ViewModels
{
    public class RegisterViewModel
    {
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(70)]
        public string Surname { get; set; }
        [Required, StringLength(200)]
        public string Username { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Compare(nameof(Password)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Moksh.PSAS.Common
{
    public class LoginModel
    {

        
        public int PeopleID { get; set; }
        [Display(Name ="UserEmail")]
        [Required(ErrorMessage = "Please enter your email" )]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter a password ")]
        public string Password { get; set; }
        
    }
}
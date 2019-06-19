using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Utilities
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

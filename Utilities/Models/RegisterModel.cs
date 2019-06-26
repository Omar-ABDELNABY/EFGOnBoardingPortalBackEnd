using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Utilities
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Type is Required")]
        public InitiatorType Type { get; set; }

        public int? ClHubSubID { get; set; }            //Client or Hub or Subhub ID

    }

    public enum InitiatorType
    {
          Admin=1, Client = 2, Hub = 3, Subhub = 4
    }
}

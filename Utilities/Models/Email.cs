using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Utilities
{
    public class Email
    {
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string From { get; set; }

        [Required]
        public string FromPassword { get; set; }

        [Required]
        [EmailAddress]
        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }


    }
}

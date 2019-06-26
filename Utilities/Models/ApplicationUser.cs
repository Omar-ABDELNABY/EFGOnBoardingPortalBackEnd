using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Utilities;

namespace Utilities
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int TraderContact { get; set; }
        public int ITContact { get; set; }
        public bool Deactivated { get; set; }
        public bool Approval { get; set; }
        // public InitiatorType InitiatorType { get; set; }

        public int? HubID { get; set; }
        public Hub Hub { get; set; }
        public int? SubhubID { get; set; }
        public Subhub Subhub { get; set; }
        public int? ClientID { get; set; }
        public Client Client { get; set; }

    }

    
}

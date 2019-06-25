using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class Subhub
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new HashSet<ApplicationUser>();

    }
}

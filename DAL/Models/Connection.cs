using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Connection
    {

        public int? ConnectionID { get; set; }

        public string TargetRegion { get; set; }

        //  Navigational Properties
        public ApplicationUser Initiator { get; set; }
        public Client ConnClient { get; set; }
        public Hub ConnHub { get; set; }
        public Subhub ConnSubHub { get; set; }

        public bool Deactivated { get; set; }
        public bool Approval { get; set; }
    }
}

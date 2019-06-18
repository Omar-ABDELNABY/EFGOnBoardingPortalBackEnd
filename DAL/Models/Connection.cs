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
        public string OMS { get; set; }

        public string Tag21 { get; set; }
        public string Tag48 { get; set; }
        public string Tag55 { get; set; }
        public string Tag100 { get; set; }
        public string Tag207 { get; set; }
        public string Tag1 { get; set; }
        public string Tag30 { get; set; }
        public string Tag115 { get; set; }

        public bool Deactivated { get; set; }
        public bool Approval { get; set; }
    }
}

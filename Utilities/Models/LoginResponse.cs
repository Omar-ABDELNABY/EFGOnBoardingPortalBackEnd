using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Utilities
{
    public class LoginResponse
    {
        public string token { get; set; }
        public DateTime expiration { get; set; }
        public bool success { get; set; }
        public Claim[] claims { get; set; }
        public bool RememberMe { get; set; }
    }
}

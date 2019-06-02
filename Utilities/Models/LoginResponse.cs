using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class LoginResponse
    {
        public string token { get; set; }
        public DateTime expiration { get; set; }
        public bool success { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Request
{
    class AuthorizationResponse
    {
        public bool Success { get; set; }
        public DataAuth data { get; set; }
    }

    class DataAuth
    {
        public string Token { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Request
{
    public class AuthorizationRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}

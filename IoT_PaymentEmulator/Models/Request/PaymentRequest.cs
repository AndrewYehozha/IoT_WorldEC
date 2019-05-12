using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Request
{
    class PaymentRequest
    {
        public int UserId { get; set; }
        public int Entert_CenterId { get; set; }
        public int ServiceId { get; set; }
        public decimal Cost { get; set; }
        public bool IsBonusPayment { get; set; }
    }
}

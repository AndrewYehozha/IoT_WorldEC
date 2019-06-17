using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Response
{
    class Entert_CenterResponse
    {
        public bool Success { get; set; }
        public List<DataEC> data { get; set; }
    }

    class DataEC
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool IsParking { get; set; }
    }
}

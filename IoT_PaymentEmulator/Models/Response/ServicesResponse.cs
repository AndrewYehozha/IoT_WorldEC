using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Response
{
    class ServicesResponse
    {
        public bool Success { get; set; }
        public List<DataServices> data { get; set; }
    }

    class DataServices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}

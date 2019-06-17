using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_PaymentEmulator.Models.Response
{
    class UserResponse
    {
        public bool Success { get; set; }
        public List<DataUser> data { get; set; }
    }

    class DataUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsBlocked { get; set; }
        public int BonusScore { get; set; }
    }
}

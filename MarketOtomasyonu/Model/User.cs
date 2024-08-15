using MarketOtomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Model
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string area { get; set; }

        public string email { get; set; }

        public string permission { get; set; }

        public string securityQuestion { get; set; }

        public string securityAnswer { get; set; }

        public LoginStatus status { get; set; }
    }
}

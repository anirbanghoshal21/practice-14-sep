using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUser
{
    [Serializable()]
    public class Customer
    {
       public int UserId { get; set; }
        public string Password { get; set; }
        public   int Date { get; set; } 

    }
}

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
        private bool loginstatus = true;

        public bool ValidateUser()
        {
           bool status = false;
            return loginstatus;
        }

        internal bool loginstatus()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerUser;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace CustomerUser
{
    internal class Program
    {
        private static void binarySerialization()
        {
            Customer cust1 = new Customer();
            cust1.UserId = 101;
            cust1.Password = "123456789";
            bool validate = cust1.loginstatus();

            FileStream fs = new FileStream(@"loginstatus.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, cust1);

            fs.Flush();
            fs.Close();
            fs.Dispose();

        }
    }
}

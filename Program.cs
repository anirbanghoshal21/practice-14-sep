using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerUser;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CustomerUser
{
    internal class Program
    {
        
        
        private static void SoapSerialize()
        {
            Stock sto1 = new Stock();
            sto1.id = 102;
            sto1.AvailableStock();

            FileStream fs2 = new FileStream("empdataSoap.soap", FileMode.Create, FileAccess.Write);

            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(fs2, sto1);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();
        }

        private class Stock
        {
        }
    }
}

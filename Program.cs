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
        
        
        private static void JsonDeSerialization()
        {
            FileStream fs = new FileStream("movjson.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s1 = sr.ReadToEnd();


            JavaScriptSerializer js = new JavaScriptSerializer();

            Movie movo = js.Deserialize<Movie>(s1);
            Console.WriteLine(movo.Movie1);
            Console.WriteLine(movo.Movie2);
            Console.WriteLine(movo.Movie3);
            Console.WriteLine(movo.Movie4);
            Console.WriteLine(movo.Movie5);
        }
    }
}

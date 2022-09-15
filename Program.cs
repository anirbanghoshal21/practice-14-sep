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

namespace CustomerUser
{
    internal class Program
    {
        
        private static void xmlSerialize()
        {
            FileStream fs_xml = new FileStream(@"moviedata.xml", FileMode.Create, FileAccess.Write);
            movie mov1 = new movie();
            mov1.Movid = 102;
            mov1.Movname = "Transformer";
            mov1.Language = "English";
            mov1.Genres = "Action";
            int User = mov1.SearchMovie();
            XmlSerializer xml = new XmlSerializer(typeof(movie));
            xml.Serialize(fs_xml, mov1);
            fs_xml.Flush();
            fs_xml.Close();
            fs_xml.Dispose();
        }
    }
}

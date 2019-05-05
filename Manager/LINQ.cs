using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLlab3
{
    class LINQ
    {
        public static List<string> ParseLinqToXML ( string par1, string par2, string par3, string par4, string par5, string par6)
        {
            List<string> list = new List<string>();
            var doc = XDocument.Load(@"D:\Прога\C#\XML(lab3)\Manager\XMLD.xml");
            var result = (from obj in doc.Descendants("videoCard")
            select new
            {
                Name = (string)obj.Attribute("Name"),
                Chip = (string)obj.Attribute("Chip"),
                Memory = (string)obj.Attribute("Memory"),
                Type = (string)obj.Attribute("Type"),
                Price = (string)obj.Attribute("Price"),
                Photo = (string)obj.Attribute("Photo"),
             }).ToList();

            foreach (var n in result)
            {
                string s = n.Name + " " + n.Chip + " " + n.Memory + " " + n.Type + " " + n.Price;// + " " + n.Photo;
                list.Add(s);
            }
            return list;
        }
    }
}

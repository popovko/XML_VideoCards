using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLlab3
{
    class SAX
    {
        public static string ParseSAX (string par1, string par2, string par3, string par4, string par5, string par6, int numVC)
        {
            int n = 1;
            string s = "" ;
            List<string> list = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\Прога\C#\XML(lab3)\Manager\XMLD.xml"); 
             XmlNode node = xmlDoc.DocumentElement;
            foreach (XmlNode nod in node.ChildNodes)
            {
                if( numVC == n)
                {
                    s = " ";
                    string st = "", s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "";
                    foreach (XmlAttribute atr in nod.Attributes)
                    {
                        if (atr.Name == "Name" && atr.Value.Contains(par2) || par2 == null)
                        {
                            s1 = atr.Value + " ";
                        }
                        if (atr.Name == "Chip" && atr.Value.Contains(par1) || par1 == null)
                        {
                            s2 = atr.Value + " ";
                        }
                        if (atr.Name == "Memory" && atr.Value.Contains(par3) || par3 == null)
                        {
                            s3 = atr.Value + " ";
                        }
                        if (atr.Name == "Type" && atr.Value.Contains(par4) || par4 == null)
                        {
                            s4 = atr.Value + " ";
                        }
                        if (atr.Name == "Price" && atr.Value.Contains(par5) || par5 == null)
                        {
                            s5 = atr.Value + " ";
                        }
                        if (atr.Name == "Photo" && atr.Value.Contains(par6) || par6 == null)
                        {
                            s6 = atr.Value + " ";
                        }
                    }
                    if (s1 != "" && s2 != "" && s3 != "" && s4 != "" && s5 != "" && s6 != "")
                    {
                        s = s1 + s2 + s3 + s4 + s5;// + s6;
                        break;
                    }

                }
                else
                {
                    n++;
                }
                
            }
            return s;
        }
    }
}

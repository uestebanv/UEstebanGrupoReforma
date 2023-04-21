using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\digis\\Documents\\Ulises Esteban Valdes\\UEstebanGrupoReforma\\XML\\Dato.xml"); // lee el documento si

            foreach (XmlNode xmlnode in doc.DocumentElement.ChildNodes)
            {
                bool ntc = xmlnode.Attributes["noticia"] != null;

                Console.WriteLine(xmlnode.Name + " " + xmlnode.InnerXml);

            }
            //    foreach (XmlNode node in xmlnode.ChildNodes)
            //    {



            //    }
            //}
            ////Console.ReadKey();   

            //XmlNodeList noticia = doc.GetElementsByTagName("noticia");

            ////XmlNodeList list = ((XmlElement)noticia[0].GetElementsByTagName("");
            //foreach(XmlElement node in noticia)
            //{
            //    //string et = node.GetAttribute("id");
            //    string c = node.InnerXml;
            //    Console.WriteLine(c);
            //}
            Console.ReadKey();
        }
    }
}

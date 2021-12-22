using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MCD_LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument(

                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("Yorum Satırı"),
                new XElement("Personellerim",
                //1.Personel
                new XElement("Personel", new XAttribute("ID", "1"),
                new XElement("İsim", "Araz"),
                new XElement("Soyisim", "Deniz"),
                new XElement("EmailAdres", "araz.deniz@gmail.com")
                ),
                //2.Personel
                new XElement("Personel", new XAttribute("ID", "2"),
                new XElement("İsim", "Hakan"),
                new XElement("Soyisim", "Kara"),
                new XElement("EmailAdres", "hakan.kara@gmail.com")
                )

                )
                );

            xDoc.Save(@"C:\XML\PersonellerimLinq.xml");

        }
    }
}

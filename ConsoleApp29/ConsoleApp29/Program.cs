using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };

            LINQReadXML();


        }
        private static void LINQReadXML()
        {
            String myXML = @"<Departments>
<Department>Account</Department>
<Department>sales</Department>
<Department>Pre-sales</Department>
<Department>Marketing</Department>
</Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
            Console.WriteLine("\nPress any key to continue .");
            Console.ReadKey();
        }
    }
}


using System;
using System.Xml;

namespace ReadXMLfromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                XmlTextReader reader = new XmlTextReader("books.xml");
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: 
                            Console.Write("<" + reader.Name);
                            Console.WriteLine(">");
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            Console.Write("</" + reader.Name);
                            Console.WriteLine(">");
                            break;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Schema;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleAppAutoStation
{
    class Program
    {
        static void XmlFromList(List<Car> cars)
        {
            XDocument xDoc = new XDocument();
            XElement xRoot = new XElement("Cars");

            foreach (var item in cars)
            {
                XElement xElem = new XElement("Car",
                                              new XAttribute("model", item.Model),
                                              new XAttribute("marka", item.Marka),
                                              new XElement("number", item.Number)
                    );
                //Console.WriteLine(item);
                xRoot.Add(xElem);
            }
            xDoc.Add(xRoot);
            xDoc.Save("car1.xml");
        }

        /// <summary>
        /// Начитуємо таблицю з БД
        /// </summary>
        /// <returns>Список Cars</returns>
        static List<Car> ListFromDB()
        {
            string connStr = ConfigurationManager.ConnectionStrings["autoDB"].ConnectionString;
            //SqlConnection conn = new SqlConnection(connStr);
            DataContext db = new DataContext(connStr);
            Table<Car> carTable = db.GetTable<Car>();

            return carTable.ToList<Car>();
        }

        static void ListFromXmlSerializer(List<Car> cars)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));
            FileStream fileStream = new FileStream("car2.xml", FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, cars);
            fileStream.Close();
        }

        static void CreateXSDSchema()
        {
            //Create
            XmlSchemaInference infer = new XmlSchemaInference();
            XmlSchemaSet xmlSchemaSet = infer.InferSchema(new XmlTextReader("car1.xml"));
            XmlWriter xmlWriter = XmlWriter.Create("car.xsd");

            foreach (XmlSchema schema in xmlSchemaSet.Schemas())
            {
                schema.Write(xmlWriter);
            }
            xmlWriter.Close();
        }

        static void ValidateXml()
        {
            //Validate
            XDocument newDocument = XDocument.Load("car.xsd");
            Console.WriteLine("\nИзвлеченная схема: \n");
            Console.WriteLine(newDocument);
        }

        static void Main(string[] args)
        {
            List<Car> cars = ListFromDB();
            //XmlFromList(cars);
            //ListFromXmlSerializer(cars);
            //CreateXSDSchema();


            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));
            FileStream fs = new FileStream("CAR.json", FileMode.OpenOrCreate);
            jsonFormatter.WriteObject(fs, cars);
            fs.Close();

            Console.WriteLine("Finish.");
            Console.ReadKey();
        }
    }
}

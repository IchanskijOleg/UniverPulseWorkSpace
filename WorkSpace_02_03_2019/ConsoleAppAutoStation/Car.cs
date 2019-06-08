using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ConsoleAppAutoStation
{
    [DataContract]
    [Serializable]
    [Table(Name = "Cars")]
    public class Car
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdCar { get; set; }
        [DataMember]
        [XmlElement]
        [Column]
        public string Number { get; set; }
        [DataMember]
        [XmlAttribute]
        [Column]
        public string Marka { get; set; }
        [DataMember]
        [XmlAttribute]
        [Column]
        public string Model { get; set; }
        [Column]
        public int Year { get; set; }
        [Column]
        public string Color { get; set; }
        [Column]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{IdCar}, {Number}, {Marka}, {Model}, {Year}, {Color}, {Price}";
        }
    }
}

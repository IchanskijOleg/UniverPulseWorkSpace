using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp12
{
    [Table(Name = "Cars")]
    public class Car
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdCar { get; set; }
        [Column]
        public string Number { get; set; }
        [Column]
        public string Marka { get; set; }
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

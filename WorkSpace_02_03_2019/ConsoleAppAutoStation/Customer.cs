using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutoStation
{
    [Table(Name = "Customers")]
    class Customer
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]        
        public int IdCustomer { get; set; }
        [Column]
        public int IdCar { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string City { get; set; }
        [Column]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{IdCustomer}, {IdCar}, {Name}, {City}, {Phone}";
        }
    }
}

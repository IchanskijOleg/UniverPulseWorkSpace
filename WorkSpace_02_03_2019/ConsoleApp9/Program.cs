using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            DAOBuses buses = new DAOBuses("myDB2");
            buses.PrintConnectionInfo();
            Console.WriteLine();

            //buses.Delete(100);
            //buses.Delete(116);

            Console.WriteLine();
            //buses.Insert("Rima", 100);
            //buses.Insert("Nima", 101); 
            buses.InsertParam("Sima", 103); 
            buses.Show();

            List<Bus> list = new List<Bus>();
            buses.FillBusFromDB(list);

            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Linq;

namespace ConsoleApp12
{
    class Program
    {
        public static IEnumerable<Table<Car>> GetLinqToSql(Table<Car> car)
        {
            var allTableCars = from item in car 
                               where item.Marka == "BMW"
                               select car;
            return allTableCars;
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car { IdCar = 1, Number = "AA121BB",Marka = "Ford", Model = "Focus", Color = "red", Year = 2000, Price = 10000},
                new Car { IdCar = 2, Number = "AA122BB",Marka = "BMW", Model = "i3", Color = "red", Year = 2010, Price = 30000},
                new Car { IdCar = 3, Number = "AA123BB",Marka = "Audi", Model = "A8", Color = "red", Year = 2005, Price = 19000},
                new Car { IdCar = 4, Number = "AA124BB",Marka = "Ford", Model = "Fiesta", Color = "red", Year = 2015, Price = 20000},
                new Car { IdCar = 5, Number = "AA125BB",Marka = "Ford", Model = "Kuga", Color = "Black", Year = 2007, Price = 1000}
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer {IdCustomer = 1, IdCar = 6, City = "Kyiv", Name ="Tom", Phone = "67670" },
                new Customer {IdCustomer = 2, IdCar = 9, City = "Lviv", Name ="Sem", Phone = "67671" },
                new Customer {IdCustomer = 3, IdCar = 10, City = "Odessa", Name ="Lee", Phone = "67672" }
            };

            var allCars = from car in cars
                          select car;

            var allFordCars = from car in cars
                              where car.Marka == "Ford"
                              select car;

            var allModelFordCars = from car in cars
                                   where car.Marka == "Ford"
                                   select new { car.Marka, car.Model };

            var allCustomerFordCars = from car in cars
                                      join customer in customers on car.IdCar equals customer.IdCar
                                      where car.Marka == "Ford"
                                      select new { car.Model, customer.Name };

            var allCustomerFordCarsNew = from car in allFordCars
                                         join customer in customers on car.IdCar equals customer.IdCar
                                         select new { car.Model, customer.Name };

            var allBuyCars = from car in cars
                             join customer in customers on car.IdCar equals customer.IdCar
                             select car;

            //var allNotBuyCars = (from car in cars select car).Except(from customer in allBuyCars select customer.car);
            var allNotBuyCars = (from car in cars select car).Except(allBuyCars);

            var allInfoCarsByCustomer = from car in cars
                                        join customer in customers on car.IdCar equals customer.IdCar
                                        where customer.Name == "Tom"
                                        select car;

            var allCarsDescPriceWithoutExpensive = (from car in cars
                                                    where car.Price > 10000
                                                    orderby car.Price descending
                                                    select car).Skip(1);
            var allCarsDescPriceWithoutExpensive_new = (from car in cars.Where(p => p.Price > 10000).OrderByDescending(p => p.Price).Skip(1) select car);

            //var allCustomerGroupCity = from customer in customers
            //                            join car in cars on  customer.Number equals car.Number 
            //                            orderby car.Marka ascending
            //                            group customer by customer.City into groupCity
            //                            select groupCity;
            //foreach (var group in allCustomerGroupCity)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            Console.WriteLine();

            foreach (var item in allCarsDescPriceWithoutExpensive)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Console.WriteLine();
            //var fordVar = allModelFordCars.ToList();
            //foreach (var item in fordVar)
            //{
            //    Console.WriteLine(item);
            //}

            string strConn = ConfigurationManager.ConnectionStrings["autoDB"].ConnectionString;
            DataContext db = new DataContext(strConn);

            // Получаем таблицу пользователей
            Table<Car> carTable = db.GetTable<Car>();
            //carTable.InsertAllOnSubmit(cars);
            //db.SubmitChanges();
            Console.WriteLine();
            //
            foreach (var item in GetLinqToSql(carTable))
            {
                foreach (var t in item)
                {
                     
                } 
                Console.WriteLine(item.ToString());
            } 
            //

            Table<Customer> customerTable = db.GetTable<Customer>();
            //customerTable.InsertAllOnSubmit(customers);
            //db.SubmitChanges();

            // возьмем первого пользователя
            Customer user1 = db.GetTable<Customer>().Where(p => p.IdCustomer == 2).SingleOrDefault();
            // и изменим у него возраст
            user1.Phone = "+3067670";
            // сохраним изменения
            db.SubmitChanges();
            //customerTable.DeleteOnSubmit(user1);
            //db.SubmitChanges();

            var allTableCars = from car in carTable
                               where car.Marka == "Ford"
                               select car;

            //foreach (var item in allTableCars)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in db.GetTable<Customer>().OrderBy(p => p.IdCar))
            {
                Console.WriteLine(item);
            }

            int countDel = db.ExecuteCommand("delete from Customers where IdCustomer = {0}", 6);
            Console.WriteLine(countDel);

            IEnumerable<Customer> cust = db.ExecuteQuery<Customer>("select * from Customers where IdCar = {0}", 6);
            Console.WriteLine();

            foreach (var item in cust)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            CarDataContext db1 = new CarDataContext(strConn);
            double minPrice = 0, maxPrice = 0;
            string name = "Ford";
            db1.GetCarPriceRange(name, ref minPrice, ref maxPrice);
            Console.WriteLine("Для марки {0} минимальная цена: {1} максимальная цена: {2}", name, minPrice, maxPrice);

            Console.ReadKey();
        }
    }
}

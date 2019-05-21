using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp9
{
    public class DAOBuses
    {
        SqlConnection conn;
        public DAOBuses(string conn_name)
        {
            string connStr = ConfigurationManager.ConnectionStrings[conn_name].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        public void PrintConnectionInfo()
        {
            conn.Open();
            // Вывод информации о подключении
            Console.WriteLine("Свойства подключения:");
            Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
            Console.WriteLine("\tБаза данных: {0}", conn.Database);
            Console.WriteLine("\tСервер: {0}", conn.DataSource);
            Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
            Console.WriteLine("\tСостояние: {0}", conn.State);
            Console.WriteLine("\tWorkstationld: {0}", conn.WorkstationId);
            conn.Close();
        }
        public void Insert(string name, int route)
        {
            conn.Open();

            string sqlInsert = $"INSERT INTO BUSES(id,name,route) VALUES((NEXT VALUE FOR SEQ_Buses_id),'{name}',{route})";
            SqlCommand command = new SqlCommand(sqlInsert, conn);
            Console.WriteLine("К-во вставок =" + command.ExecuteNonQuery());
            conn.Close();
        }
        public void InsertParam(string name, int route)
        {
            conn.Open();

            string sqlInsert = $"INSERT INTO BUSES(id,name,route) VALUES((NEXT VALUE FOR SEQ_Buses_id),@name,@route)";
            SqlCommand command = new SqlCommand(sqlInsert, conn);

            SqlParameter pName = new SqlParameter("@name", name);
            command.Parameters.Add(pName);
            SqlParameter pRoute = new SqlParameter("@route", route);
            command.Parameters.Add(pRoute);

            Console.WriteLine("К-во вставок =" + command.ExecuteNonQuery());
            conn.Close();
        }
        public void Delete(int route)
        {
            conn.Open();
            string sqlDelete = $"DELETE FROM BUSES WHERE route= {route}";
            SqlCommand command = new SqlCommand(sqlDelete, conn);
            Console.WriteLine("К-во удалений =" + command.ExecuteNonQuery());
            conn.Close();
        }
        public void FillBusFromDB(List<Bus> data)
        {
            conn.Open();
            string sqlSelect = $"select * from buses";
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(new Bus(Convert.ToInt32(reader["id"]),
                                     Convert.ToString(reader["name"]),
                                     Convert.ToInt32(reader["route"]))
                            );
                }
            }
            conn.Close();
        }
        public void Show()
        {
            conn.Open();
            string sqlSelect = $"select * from buses";
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + "\t");
                }
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            conn.Close();
        }
    }
}

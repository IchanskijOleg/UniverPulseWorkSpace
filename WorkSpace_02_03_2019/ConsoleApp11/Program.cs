using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string sqlSelect = "Select * from customers";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect, conn);
            DataSet set = new DataSet();
            adapter.Fill(set);
            DataTable t = set.Tables[0];

            Console.WriteLine(t.TableName.ToString());

            foreach (DataColumn column in t.Columns)
            {
                Console.Write("\t{0}", column.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in t.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    Console.Write("\t{0}", cell);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

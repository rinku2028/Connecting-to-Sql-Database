using System;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(str);
            try
            {
                sqlconn.Open();
                Console.WriteLine("Database connected");
            }
            catch
            {
                Console.WriteLine("Database not connected");
            }
            Console.ReadLine();


        }
    }
}

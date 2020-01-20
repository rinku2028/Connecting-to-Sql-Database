using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dataconn
{
    class fetchdata
    {
        static void Main(string[] args)
        {

            //fetching data from sql and displaying in console
            string sql = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sql);
            try
            {
                conn.Open();
                Console.WriteLine("Connection opened");
                SqlCommand sqldata = new SqlCommand("select * from info", conn);
                sqldata.CommandType = CommandType.Text;
                SqlDataReader dr = sqldata.ExecuteReader();
                //  if (dr.Read())
                while (dr.Read())
                {
                    Console.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString());
                }

            }
            catch
            {
                Console.WriteLine("Database not connected");
            }
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dataconn
{
    class insertintodb
    {
        static void Main(string[] args)
        { 
            //Inserting Data Table Values to Sql
            string sql = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sql);
            try
            {
                conn.Open();
                Console.WriteLine("Database connected");
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("id",typeof(string));
                dt.Columns.Add("name",typeof(string));
                dt.Rows.Add("0001", "Harry");
                dt.Rows.Add("0002","Sarin");
               
              
                string t = dt.Rows[0].ItemArray[0].ToString();
                string t1 = dt.Rows[0].ItemArray[1].ToString();
                Console.WriteLine(t+"\t"+t1);
                string s = "insert into info(id,name) values(@id,@name)";
        
                SqlCommand sqlcmd = new SqlCommand(s, conn);
       
               sqlcmd.Parameters.AddWithValue("id", dt.Rows[1].ItemArray[0].ToString());
               sqlcmd.Parameters.AddWithValue("name",dt.Rows[1].ItemArray[1].ToString());
               sqlcmd.ExecuteNonQuery();
               conn.Close();
               Console.WriteLine("Data inserted successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Database not connected");
            }
Console.ReadLine();


        }
    }
}

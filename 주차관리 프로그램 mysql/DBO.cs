using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주차관리_프로그램_연습
{
    class DBO
    {
        public SqlConnection conn = new SqlConnection();
        

        private void ConnetDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" +
                "Initial Catalog ={1};" +
                "Integrated Security={2};"+
                "Timeout = 3"
                , "local", "MYDB2", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }


        private void CreateDB()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Create table CarPark parkingspot";
        }

        public void Query_Select()
        {
            ConnetDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from carpark";
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "carpark");
            
            
           
            conn.Close();
            
 
        }

     

      

        private void Query_Update(string parkigspot, string carnumber, string drivername, string phonenumber, string parkingtime)
        {
            ConnetDB();
            string sqlcommand = "Update carpark set carnumber =@p1, driverName =@p2, phonenumber =@p3, parkingtime=@p4 where parkingspot = p ";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", carnumber);
            cmd.Parameters.AddWithValue("@p2", drivername);
            cmd.Parameters.AddWithValue("@p3", phonenumber);
            cmd.Parameters.AddWithValue("@p4", parkingtime);
            cmd.Parameters.AddWithValue("@p", parkigspot);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            conn.Close();

        }


    }
}

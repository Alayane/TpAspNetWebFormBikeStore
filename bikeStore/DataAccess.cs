using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace bikeStore
{
    
    public class DataAccess
    {
        public static string str = ConfigurationManager.ConnectionStrings["cnxBikeStore"].ConnectionString;

        public static void setData( SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(str);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public static DataTable getData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(str);
            cmd.Connection = con;
            con.Open();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            return dt;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace RMS
{
    internal class Datacon
    {
        public static SqlConnection con()
        {
            SqlConnection con;
            //string path = @"Data Source =.; Initial Catalog = R_M_S; Integrated Security = true";
            string path = ConfigurationManager.ConnectionStrings["RMS.Properties.Settings.R_M_SConnectionString"].ConnectionString;
            try
            {
                con = new SqlConnection(path);
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }


        }




    }
}

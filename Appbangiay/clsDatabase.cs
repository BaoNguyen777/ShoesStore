using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Appbangiay
{

    class connectionString
    {
        public static string con = "Server=LAPTOP-Q056MBAS\\SQLEXPRESS;Database=QLShopGiay;integrated security=true";
    }
    internal class clsDatabase
    {
        public static SqlConnection con;
        
         
        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=LAPTOP-Q056MBAS\\SQLEXPRESS;Database=QLShopGiay;integrated security=true");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

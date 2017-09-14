using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FrelardAPI.Controllers
{
    public class FrelardController : ApiController
    {
        public string get()
        {
            var ret = "";
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var sql = "select * from [dbo].[tblFrelardMockup]";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret += reader[0].ToString() + "," + reader[0].ToString() + "<br>";
                    }
                }
                conn.Close();
            }
            return ret;
        }

        public void updateInventory(string sku, int newInventoryLevel)
        {

        }
    }
}

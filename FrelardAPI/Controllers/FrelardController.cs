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
            if(string.IsNullOrEmpty(sku) || newInventoryLevel < 0)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var sql = "update tblFrelardMockup SET Inventory_Level = @newInv where sku = @sku";
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@newInv", newInventoryLevel));
                cmd.Parameters.Add(new SqlParameter("@sku", sku));
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
    }
}

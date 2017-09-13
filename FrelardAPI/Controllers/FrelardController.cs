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
            var ret = "foobarz";
            //using (SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=E:\SandBox\FrelardAPI\FrelardAPI\data\testa.db;Version=3;"))
            //{
            //    sqlite_conn.Open();
            //    var sql = "select * from tbltest";
            //    SQLiteCommand cmd = new SQLiteCommand(sql, sqlite_conn);
            //    using(SQLiteDataReader reader = cmd.ExecuteReader())
            //    {
            //        while(reader.Read())
            //        {
            //            ret += reader[0].ToString() + "," + reader[0].ToString() + "<br>";
            //        }
            //    }

            //}
            return ret;
        }
    }
}

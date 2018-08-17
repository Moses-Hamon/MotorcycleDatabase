using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//adding in the usings
using System.IO;
using System.Data.SQLite;
using Dapper;

namespace MotorcycleDatabase
{
    //add and make the class static
    public static class Database
    {
        const string DB_NAME = "moto.db";
        static string CONNECTION_STRING;
        

        static Database()
        {
            var DB_PATH = HttpContext.Current.Server.MapPath($"~/App_Data/{DB_NAME}");
            CONNECTION_STRING = $"Data Source={DB_PATH}";

            var SCHEMA_PATH = HttpContext.Current.Server.MapPath($"~/App_Data/schema.txt");
            var query = File.ReadAllText(SCHEMA_PATH);

            var db = GetSQLiteConnection();
            db.Execute(query);
        }

        public static SQLiteConnection GetSQLiteConnection()
        {
            return new SQLiteConnection(CONNECTION_STRING);
        }

    }
}
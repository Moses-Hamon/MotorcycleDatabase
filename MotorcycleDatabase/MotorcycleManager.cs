using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SQLite;

namespace MotorcycleDatabase
{
    // go go gadget static
    public static class MotorcycleManager
    {
        const string QUERY_SELECT_ALL = "SELECT * FROM motorcycles";
        const string QUERY_SELECT_ONE = "SELECT * FROM motorcycles WHERE id = @id";
        const string QUERY_INSERT_INTO = "INSERT INTO motorcycles (manufacturer, model, alias, capacity, learner) VALUES (@Manufacturer, @Model, @Alias, @Capacity, @Learner);";
        const string QUERY_UPDATE = "UPDATE motorcycles SET manufacturer=@Manufacturer, model=@Model, alias=@Alias, capacity=@Capacity, learner=@Learner WHERE id=@id;";


        public static List<Motorcycle> SelectAll()
        {
            var db = Database.GetSQLiteConnection();
            return db.Query<Motorcycle>(QUERY_SELECT_ALL).ToList();

        }

        public static Motorcycle SelectOne(string id)
        {
            var db = Database.GetSQLiteConnection();
            var param = new { id };
            return db.QuerySingle<Motorcycle>(QUERY_SELECT_ONE, param);
        }

        public static Motorcycle Save(Motorcycle record)
        {
            if (record.Id == 0) return Insert(record);
            else return Update(record);
        }

        static Motorcycle Update(Motorcycle record)
        {
            var db = Database.GetSQLiteConnection();
            db.Execute(QUERY_UPDATE, record);
            return record;
        }

        static Motorcycle Insert(Motorcycle record)
        {
            var db = Database.GetSQLiteConnection();
            //database must be manually opened and closed for this
            db.Open();
            var results = db.Execute(QUERY_INSERT_INTO, record);
            record.Id = db.LastInsertRowId;
            db.Close();

            return record;
        }
    }
}
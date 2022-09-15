using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ListView.models;

namespace ListView.data
{
    public class SQliteHelper
    {
        SQLiteAsyncConnection db;
        public SQliteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Alumno>().Wait();
        }
    }
}

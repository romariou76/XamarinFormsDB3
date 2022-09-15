using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ListView.models;
using System.Threading.Tasks;

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

        //Creamos el registro en la bd
        public Task<int> SaveAlumnoAsync(Alumno alum)
        {
            if (alum.IdAlumno == 0)
            {
                return db.InsertAsync(alum);
            }
            else
            {
                return null;
            }

        }
    }
}

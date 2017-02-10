using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Android.Util;

namespace Android.Model.DAL
{
    public class DbContext
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDatabase()
        {
            try
            {
                using (var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db")))
                {
                    conn.CreateTable<Question>();
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool insertQuestion(Question q)
        {
            try
            {
                using (var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db")))
                {
                    conn.Insert(q);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public List<Question> selectQuestions()
        {
            try
            {
                using (var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db")))
                {

                    return conn.Table<Question>().ToList();
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }


    }
}
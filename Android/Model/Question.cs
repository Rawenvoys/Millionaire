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

namespace Android.Model
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public int Category { get; set; }
        public string Answer { get; set; }

        public override string ToString()
        {
            return string.Format("[Question ID={0}, Title={1}, A={2}, B={3}, C={4}, D={5}, Category={6}, Answer={7}]", ID, Title, A, B, C, D, Category, Answer);
        }

    }
}
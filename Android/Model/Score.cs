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
using Java.Lang;

namespace Android.Model
{
    public class Score
    {
        public int ScoreId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Score(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
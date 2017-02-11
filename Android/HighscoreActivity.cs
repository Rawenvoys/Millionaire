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
using Android.Adapters;
using Android.Model;

namespace Android
{
    [Activity(Label = "Ranking", ScreenOrientation = Content.PM.ScreenOrientation.Portrait)]
    public class HighscoreActivity : Activity
    {
        public List<Score> list;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Highscore);
            list = new List<Score>();
            //list.Add(new Score("Lucato", 1000000));
            //list.Add(new Score("Adam", 1000));
            //list.Add(new Score("Magda", 40000));

            HighscoreAdapter highscoreAdapter = new HighscoreAdapter(this, list);
            ListView highscoreListView = (ListView)FindViewById(Resource.Id.highscoreListView);
            highscoreListView.Adapter = highscoreAdapter;
            if (highscoreAdapter.scoreList.Count == 0)
            {
                Toast emptyListToast = Toast.MakeText(this, "Baza wyników jest pusta", ToastLength.Short);
                emptyListToast.Show();
            }

        }
    }
}
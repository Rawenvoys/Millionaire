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
using Android.Model;

namespace Android.Adapters
{
    public class HighscoreAdapter : BaseAdapter
    {
        public List<Score> scoreList { get; set; }
        Activity activity;
        //?
        public HighscoreAdapter(Activity activity, List<Score> scoreList)
        {
            this.activity = activity;
            this.scoreList = scoreList;

        }

     
     

        public override int Count
        {
            get { return scoreList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return scoreList[position].ScoreId;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.HighscoreListItem, parent, false);
            TextView nameText = view.FindViewById<TextView>(Resource.Id.name);
            TextView scoreText = view.FindViewById<TextView>(Resource.Id.score);
            Score score = scoreList[position];
            nameText.Text = score.Name;
            scoreText.Text = score.Price.ToString();
            return view;
        }
    }
}
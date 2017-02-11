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

namespace Android
{
    [Activity(Label = "Nowa gra")]
    public class GameActivity : Activity
    {

        float x1, x2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Game);

        }

        public override bool OnTouchEvent(MotionEvent touchevent)
        {
            switch (touchevent.Action)
            {
                case MotionEventActions.Down:
                    {
                        x1 = touchevent.GetX();
                        break;
                    }
                case MotionEventActions.Up:
                    {
                        x2 = touchevent.GetX();

                        if (x1 < x2)
                        {
                            //Toast.MakeText(this, "Left to Right Swap Performed", ToastLength.Long).Show(); //Powrót
                            SetContentView(Resource.Layout.Game);
                            OverridePendingTransition(Resource.Animation.SlideInLeft, Resource.Animation.SlideOutRight);
                        }

                        if (x1 > x2)
                        {
                            //Toast.MakeText(this, "Right to Left Swap Performed", ToastLength.Long).Show(); //Okno poziomów
                            SetContentView(Resource.Layout.Levels);
                            OverridePendingTransition(Resource.Animation.SlideInRight, Resource.Animation.SlideOutLeft);
                        }



                        break;
                    }
            }
            return false;
        }
    }
}
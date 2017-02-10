using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace Android
{
    [Activity(Label = "Hard with Million", MainLauncher = true, Icon = "@drawable/logo")]
    public class MainActivity : Activity
    {
        private ImageView logo;
        private MediaPlayer mainTheme;
        private Button startGame;
        private Button highscore;
        private Button endGame;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            logo = (ImageView)FindViewById(Resource.Id.logo);
            logo.SetImageResource(Resource.Drawable.Logo);
            startGame = (Button)FindViewById(Resource.Id.startGameButton);
            highscore = (Button)FindViewById(Resource.Id.highscoreButton);
            endGame = (Button)FindViewById(Resource.Id.endGameButton);
            mainTheme = MediaPlayer.Create(this, Resource.Raw.MainTheme);
            mainTheme.Start();

            endGame.Click += delegate
            {
                mainTheme.Stop();
                Finish();
                Process.KillProcess(Process.MyPid());
            };

            startGame.Click += delegate
            {
                mainTheme.Stop();
                StartActivity(typeof(GameActivity));
            };

            highscore.Click += delegate
            {
                mainTheme.Stop();
                StartActivity(typeof(HighscoreActivity));
            };
           

            
        }
    }
}


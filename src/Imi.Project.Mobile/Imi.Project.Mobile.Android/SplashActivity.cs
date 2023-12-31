﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Droid
{
    [Activity(Label = "Shelter Helper", Icon = "@drawable/kennel", Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }
        // Prevent the back button from canceling the startup process
        public override void OnBackPressed() { }
        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
            Log.Debug("Shelter Helper", "Performing some startup work that takes a bit of time.");
            await Task.Delay(100); // Simulate a bit of startup work.
            Log.Debug("Shelter Helper", "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
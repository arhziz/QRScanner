using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRScanner.Droid
{
    [Activity(
        Label = "Basic QR Scanner", 
        Theme = "@style/MainTheme.Splash",
        NoHistory = true,
        Icon = "@mipmap/ic_launcher"
        )]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task StartupWork = new Task(() => {
                SimulateStartup();
            });

            StartupWork.Start();
        }

        private async void SimulateStartup()
        {
            await Task.Delay(1000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }


    }
}
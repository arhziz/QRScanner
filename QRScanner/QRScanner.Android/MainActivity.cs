using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;
using System.Threading.Tasks;
using Android.Content;

namespace QRScanner.Droid
{
    [Activity(
        Label = "QRScanner", 
        Icon = "@mipmap/ic_launcher",
        MainLauncher = true,
        Theme = "@style/MainTheme.Launcher", 
       
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            Window.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);
            LoadApplication(new App());
        }
        //protected override void OnResume()
        //{
        //    base.OnResume();

        //    Task StartupWork = new Task(() => {
        //        SimulateStartup();
        //    });

        //    StartupWork.Start();
        //}

        //private async void SimulateStartup()
        //{
        //    await Task.Delay(1000);
        //    StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        //}
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            //global::ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
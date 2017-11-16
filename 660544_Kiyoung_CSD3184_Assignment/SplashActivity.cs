
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _Kiyoung_CSD3184_Assignment
{
    [Activity(Label = "SplashActivity", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SplashLayout);

            Task startUp = new Task(() => { slash(); });

            startUp.Start();
        }

        async void slash()
        {
            await Task.Delay(1000);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

        }
    }
}

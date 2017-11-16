
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

namespace _Kiyoung_CSD3184_Assignment
{
    [Activity(Label = "VisitedCountries_Activity")]
    public class VisitedCountries_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.countriesList);

            ListView countryList = FindViewById<ListView>(Resource.Id.list_vw_countries);




        }
    }
}

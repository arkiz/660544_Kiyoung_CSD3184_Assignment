
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

        List<TableItem> tableItems = new List<TableItem>();

        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.listScreen);

            listView = FindViewById<ListView>(Resource.Id.List);

            tableItems.Add(new TableItem() { Heading = "Seoul", SubHeading = "South Korea", ImageResourceId = Resource.Drawable.kr });
            tableItems.Add(new TableItem() { Heading = "Toronto", SubHeading = "Canada", ImageResourceId = Resource.Drawable.ca });
            tableItems.Add(new TableItem() { Heading = "Quebec", SubHeading = "Canada", ImageResourceId = Resource.Drawable.ca });
            tableItems.Add(new TableItem() { Heading = "Paris", SubHeading = "France", ImageResourceId = Resource.Drawable.fr });
            tableItems.Add(new TableItem() { Heading = "Rome", SubHeading = "Italy", ImageResourceId = Resource.Drawable.it });
            tableItems.Add(new TableItem() { Heading = "Lucerne", SubHeading = "Switzerland", ImageResourceId = Resource.Drawable.ch });


            listView.Adapter = new HomeScreenAdapter(this, tableItems);

            listView.ItemClick += OnListItemClick;

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            //Toolbar will now take on default actionbar characteristics
            SetActionBar(toolbar);

            toolbar.InflateMenu(Resource.Menu.home);
            toolbar.MenuItemClick += (sender, e) => {
                Toast.MakeText(this, e.Item.TitleFormatted.ToString(), ToastLength.Short).Show();

                if (e.Item.TitleFormatted.ToString() == "Visited Countries")
                {
                    StartActivity(new Intent(Application.Context, typeof(VisitedCountries_Activity)));
                }
                else if (e.Item.TitleFormatted.ToString() == "Next Vacation")
                {
                    StartActivity(new Intent(Application.Context, typeof(NextVacations_Activity)));

                }
            };

        }

        protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            var t = tableItems[e.Position];
            Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
            Console.WriteLine("Clicked on " + t.Heading);
        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.home, menu);
            return base.OnCreateOptionsMenu(menu);
        }

    }
}

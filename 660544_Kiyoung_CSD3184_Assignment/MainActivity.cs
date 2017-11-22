/*
 INSTRUCTOR:
Jigisha Patel
CLASS:
2017F_CSD3184_1
Mobile Development
EVALUATION:
40% / 100%
DUE DATE:
6th December 2017
• Create a Xamarin Android application to view a travel blog. Your application should have the following facilities.
1. Start your application by displaying a splash screen containing suitable image for the application.
2. After splash screen, 
    your application should display the brief introduction about the blog author with the image.

    3. The introduction page should have a menu containing two options. 
        First, to display the list of locations visited by the blogger. 
        Second, to display the list of next vacation destinations. 
        Third, to contact the blogger.
        
4. When list of locations visited and / or next vacation destinations is selected from the options
    , it should display the list view containing image and name of the place. 
    Upon selection of a list view item it should display the details about that place with images.
5. When option to contact the blogger is selected
    , it should display the cell number and email address of the author 
    which should perform corresponding operation.
CSD3184 Mobile Development
© 2017 LAMBTON COLLEGE IN TORONTO
• Create a zip file containing your application named as CollegeID_Firstname_CSD3184_Assignment.zip and upload it on GitHub. Paste the your GitHub repository link in text file with name CollegeID_Firstname_CSD3184_Assignment.txt and upload it on Moodle for submission.
*/
using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace _Kiyoung_CSD3184_Assignment
{
    [Activity(Label = "Travel_blog")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            ////Toolbar will now take on default actionbar characteristics
            SetActionBar(toolbar);

            //ActionBar.Title = "Hello from Toolbar";

            toolbar.InflateMenu(Resource.Menu.home);
            toolbar.MenuItemClick += (sender, e) => {
                Toast.MakeText(this, e.Item.TitleFormatted.ToString(), ToastLength.Short).Show();
            
                if(e.Item.TitleFormatted.ToString() == "Visited Countries") {
                    StartActivity(new Intent(Application.Context, typeof(VisitedCountries_Activity)));
                } else if ( e.Item.TitleFormatted.ToString() == "Next Vacation"){
                    StartActivity(new Intent(Application.Context, typeof(NextVacations_Activity)));

                }
            };

            //Button btnPopupMenu = FindViewById<Button>(Resource.Id.btnPopupMenu);

            //btnPopupMenu.Click += (sender, arg) =>
            //{
            //    PopupMenu popupMenu = new PopupMenu(this, btnPopupMenu);
            //};

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.home, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Top ActionBar pressed: " + item.TitleFormatted, ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}


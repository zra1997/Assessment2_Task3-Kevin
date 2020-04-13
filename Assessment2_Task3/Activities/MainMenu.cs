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

namespace Assessment2_Task3
{
    [Activity(Label = "MainMenu")]
    public class MainMenu : Activity
    {
        Button Item1;
        Button Item2;
        Button Item3;
        Button Additem;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);

            Item1 = FindViewById<Button>(Resource.Id.item1);
            Item2 = FindViewById<Button>(Resource.Id.item2);
            Item3 = FindViewById<Button>(Resource.Id.item3);
            Additem = FindViewById<Button>(Resource.Id.Additem);

            Item1.Click += (Sender, e) =>
            {
                Intent ItemIntent1 = new Intent(this, typeof(Item1));
                StartActivity(ItemIntent1);
            };

            Item2.Click += (Sender, e) =>
            {
                Intent ItemIntent2 = new Intent(this, typeof(Item2));
                StartActivity(ItemIntent2);
            };

            Item3.Click += (Sender, e) =>
            {
                Intent ItemIntent3 = new Intent(this, typeof(Item3));
                StartActivity(ItemIntent3);

       
            };
            Additem.Click += (Sender, e) =>
            {
                Intent AdditemIntent = new Intent(this, typeof(addItem));
                StartActivity(AdditemIntent);
            };
        }

    }
}
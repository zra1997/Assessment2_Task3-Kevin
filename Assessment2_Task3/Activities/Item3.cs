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
    [Activity(Label = "Item3")]
    public class Item3 : Activity
    {
        Button Back3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.item3);

            Back3 = FindViewById<Button>(Resource.Id.Back3);

            Back3.Click += (Sender, e) =>
            {
                Intent BackIntent3 = new Intent(this, typeof(MainMenu));
                StartActivity(BackIntent3);
            };
        }
    }
}
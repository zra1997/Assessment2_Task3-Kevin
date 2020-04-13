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
    [Activity(Label = "additem")]
    public class addItem : Activity
    {
        Button Back, btnsave;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.addItem);

            Back = FindViewById<Button>(Resource.Id.Back);
            btnsave = FindViewById<Button>(Resource.Id.btnsave);

            Back.Click += (Sender, e) =>
            {
                Intent BackIntent1 = new Intent(this, typeof(MainMenu));
                StartActivity(BackIntent1);
            };

            
           

 
        }
    }
}





           
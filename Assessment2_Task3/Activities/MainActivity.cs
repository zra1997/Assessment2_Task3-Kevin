﻿using System;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;
using TaskStackBuilder = Android.Support.V4.App.TaskStackBuilder;
using Android.Content;

namespace Assessment2_Task3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        static readonly int NOTIFICATION_ID = 1000;
        static readonly string CHANNEL_ID = "location_notification";
        internal static readonly string COUNT_KEY = "count";



        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            CreateNotificationChannel();

            Button btn = FindViewById<Button>(Resource.Id.btn1);
            btn.Click += Btn1_click;

            Button btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn2.Click += Btn2_Click;

            Button btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn3.Click += Btn3_Click;

        }

        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share Text"
            });
        }

        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = uri,
                Title = "Share Web Link"
            });
        }





        private async void Btn1_click(object sender, EventArgs eventArgs)
        {
            try
            {
                NotificationCompat.Builder builder = new NotificationCompat.Builder(this, CHANNEL_ID)
                    .SetAutoCancel(false)
                    .SetSmallIcon(Resource.Drawable.ic_stat_button_click)
                    .SetContentTitle("Notification Title")
                    .SetContentText("This items sold out");



                var notificationManager = NotificationManagerCompat.From(this);
                notificationManager.Notify(NOTIFICATION_ID, builder.Build());



            }
            catch (FeatureNotSupportedException ex)
            {


            }


        }


        void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                // Notification channels are new in API 26 (and not a part of the
                // support library). There is no need to create a notification
                // channel on older versions of Android.
                return;
            }

            var name = Resources.GetString(Resource.String.channel_name);
            var description = GetString(Resource.String.channel_description);
            var channel = new NotificationChannel(CHANNEL_ID, name, NotificationImportance.Default)
            {
                Description = description
            };

            var notificationManager = (NotificationManager)GetSystemService(NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }
        private async void Btn2_Click(Object sender, EventArgs e)
        {
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            await ShareText("Hello " + editText1.Text);

            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = "https://docs.microsoft.com/en-us/xamarin/essentials/share?tabs=android",
                Title = "Share Web Link"
            });
        }
        private async void Btn3_Click(Object sender, EventArgs e)
        {
            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            string messageText = "Hi, I am interested in the item" + editText1.Text + "you have posted for sale. Could I please have more details?";
            string recipient = "021841534";
            try
            {

                var message = new SmsMessage(messageText, new[] { recipient });
                await Sms.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException ex)
            {
                Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);
                builder.SetMessage("SMS is not supported on this phone").
                    SetTitle("Feature Not Supported");
                Android.App.AlertDialog dialog = builder.Create();

            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }


        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
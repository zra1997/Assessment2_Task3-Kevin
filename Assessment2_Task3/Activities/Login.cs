using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace Assessment2_Task3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class Login : Activity
    {
        Button btnLogin;
        Button btnSignUp;
        EditText etUsername;
        EditText etPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            btnLogin.Click += (Sender, e) =>
            {
                Intent MainMenuIntent = new Intent(this, typeof(MainMenu));
                StartActivity(MainMenuIntent);

                //var request = HttpWebRequest.Create(string.Format(@"https://10.0.2.2:5001/api/Customers"));

                //request.ContentType = "application/json";
                //request.Method = "GET";
                //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                //{
                //    if (response.StatusCode != HttpStatusCode.OK)

                //        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);

                //    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                //    {
                //        var content = reader.ReadToEnd();
                //        if (string.IsNullOrWhiteSpace(content))
                //        {
                //            Console.Out.WriteLine("Response contained empty body...");
                //        }
                //        else
                //        {
                //            var userList = JsonConvert.DeserializeObject<List<User>>(content);
                //            Console.Out.WriteLine("Response Body: \r\n {0}", content);
                //            foreach (User user in userList)
                //            {
                //                if (user.UserName == etUsername.Text & user.Password == etPassword.Text)
                //                {
                //                    Toast.MakeText(this, "Welcome", ToastLength.Long);
                //                    Intent MainMenuIntent = new Intent(this, typeof(MainMenu));
                //                    StartActivity(MainMenuIntent);
                //                }
                //                else
                //                {
                //                    Toast.MakeText(this, "Failed to Login. Please retry!", ToastLength.Long);
                //                }
                //            }
                //        }
                //    }
                //}
            };

            btnSignUp.Click += (Sender, e) =>
                {
                    Intent RegisterIntent = new Intent(this, typeof(SignUp));
                    StartActivity(RegisterIntent);
                };

        }
    }
}
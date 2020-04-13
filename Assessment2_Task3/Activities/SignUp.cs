using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    [Activity(Label = "SignUp")]
    public class SignUp : Activity
    {
        Button btnConfirm;
        EditText etFirstName, etLastName, etPhone, etAddress, etCountry, etUsername, etPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUp);

            btnConfirm = FindViewById<Button>(Resource.Id.btnConfirm);
            etFirstName = FindViewById<EditText>(Resource.Id.etFirstName);
            etLastName = FindViewById<EditText>(Resource.Id.etLastName);
            etPhone = FindViewById<EditText>(Resource.Id.etPhone);
            etAddress = FindViewById<EditText>(Resource.Id.etAddress);
            etCountry = FindViewById<EditText>(Resource.Id.etCountry);
            etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);




            btnConfirm.Click += (Sender, e) =>
            {
                Intent LoginIntent = new Intent(this, typeof(Login));
                StartActivity(LoginIntent);

                //var request = HttpWebRequest.Create(string.Format(@"https://10.0.2.2:5001/api/Customers"));
                //request.ContentType = "application/json";
                //request.Method = "POST";

                //User newUser = new User();
                //newUser.UserName = etUsername.Text;
                //newUser.Password = etPassword.Text;
                //newUser.First_Name = etFirstName.Text;
                //newUser.Last_Name = etLastName.Text;
                //newUser.Phone_Number = etPhone.Text;
                //newUser.Address = etAddress.Text;
                //newUser.Country = etCountry.Text;


                //var userJason = JsonConvert.SerializeObject(newUser);


                //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                //{

                //    streamWriter.Write(userJason);
                //}
                //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                //{

                //    if (response.StatusCode != HttpStatusCode.Created)
                //    {
                //        Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                //        Toast.MakeText(this, "Failed to create user. Please retry!", ToastLength.Long);
                //    }
                //    else
                //    {
                //        Toast.MakeText(this, "User created successfully", ToastLength.Long);


                //        Intent LoginIntent = new Intent(this, typeof(Login));
                //        StartActivity(LoginIntent);
                //    }
                //}
            };
        }
    }
}
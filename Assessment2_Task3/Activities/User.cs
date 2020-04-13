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
    class User
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
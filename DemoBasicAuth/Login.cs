using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoBasicAuth
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Login()
        {
            UserName = "Nikola";
            Password = "Gerun";
        }
        public Login(string userValue, string passwordValue)
        {
            UserName = userValue;
            Password = passwordValue;
        }
    }
}
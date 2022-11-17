using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    public class ClientRegistration
    {
        string username, password;

        public ClientRegistration(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public ClientRegistration() 
        {

        }
        public override string ToString()
        {
            return "User: " + username + "| Password: " + password;
        }
    }
}

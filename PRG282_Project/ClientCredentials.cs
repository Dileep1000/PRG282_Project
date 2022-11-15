﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    public class ClientCredentials
    {
        string username, password;

        public ClientCredentials(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public ClientCredentials() 
        {

        }
        public override string ToString()
        {
            return "User: " + username + "| Password: " + password;
        }
    }
}

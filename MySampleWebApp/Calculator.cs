﻿using MySampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApp
{
    public class Calculator
    {
        public const string password = "SomeString";
        public int Add(int a, int b)
        {
            if (a==b)
            {

            }
            else
            {

            }
            string pwd = Constant.DefaultCertificatePassword;
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return b - a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
// Basklassen som både patient och läkare kommer att ärva från
namespace Sjukhussystem
{
        public class Person
        {
            // privata attributer
            private string namn;
            private int ålder;

            public string GetNamn() => namn;
            public void SetNamn(string n) => namn = n;

            public int GetÅlder() => ålder;
            public void SetÅlder(int a) => ålder = a;
        }

    }








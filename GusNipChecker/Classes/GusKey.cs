﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusNipChecker.Classes
{
    class GusKey //klasa trzymająca dane klucza dostępowego do Api
    {
        public string Key { get; set; }
        public GusKey()
        {
            this.Key = "abcde12345abcde12345";
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_TDD
{
    public class MyClass
    {
        public static bool MyMethod(double importantNumber)
        {
            if (importantNumber > 0 && importantNumber <= 5) return true;
            else return false;
        }
    }
}

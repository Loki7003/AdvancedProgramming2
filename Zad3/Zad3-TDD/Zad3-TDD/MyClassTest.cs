using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_TDD
{
    public class MyClassTest
    {
        public void MethodTest() {
            double number = 8;
            bool result = MyClass.MyMethod(number);

            ClassicAssert.AreEqual(true, result);

            Console.WriteLine(result);
        }
    }
}

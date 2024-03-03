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
            double number = 4.5;
            int result = MyClass.MyMethod(number);

            ClassicAssert.AreEqual(1, result);

            Console.WriteLine(result);
        }
    }
}

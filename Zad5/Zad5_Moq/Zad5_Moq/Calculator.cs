using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5_Moq
{
    internal class Calculator
    {
        private IWebService _webService;

        public Calculator(IWebService webService)
        {
            _webService = webService;
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            _webService.SendData($"Add operation: {a} + {b} = {result}");
            return result;
        }
    }
}

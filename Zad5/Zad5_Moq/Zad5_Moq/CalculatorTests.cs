using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Zad5_Moq
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldSendDataToWebService()
        {
            Mock<IWebService> mockWebService = new Mock<IWebService>();
            Calculator calculator = new Calculator(mockWebService.Object);

            int result = calculator.Add(3, 5);

            ClassicAssert.AreEqual(8, result);

            mockWebService.Verify(ws => ws.SendData("Add operation: 3 + 5 = 8"), Times.Once);
        }
    }
}

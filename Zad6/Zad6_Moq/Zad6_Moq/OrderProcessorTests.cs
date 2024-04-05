using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Zad6_Moq
{
    [TestFixture]
    public class OrderProcessorTests
    {
        [Test]
        public void ProcessOrder_ShouldCallPlaceOrderWithCorrectParameters()
        {
            Mock<IOrderService> mockOrderService = new Mock<IOrderService>();
            OrderProcessor orderProcessor = new OrderProcessor(mockOrderService.Object);

            orderProcessor.ProcessOrder("ProductABC", 3);

            mockOrderService.Verify(os => os.PlaceOrder("ProductABC", 3), Times.Once());
        }

        [Test]
        public void ProcessOrder_ShouldCallPlaceOrderMultipleTimes()
        {
            Mock<IOrderService> mockOrderService = new Mock<IOrderService>();
            OrderProcessor orderProcessor = new OrderProcessor(mockOrderService.Object);

            orderProcessor.ProcessOrder("Product1", 2);
            orderProcessor.ProcessOrder("Product2", 6);

            mockOrderService.Verify(os => os.PlaceOrder("Product1", 2), Times.Once);
            mockOrderService.Verify(os => os.PlaceOrder("Product2", 6), Times.Once);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6_Moq
{
    public class OrderProcessor
    {
        private IOrderService _orderService;

        public OrderProcessor(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void ProcessOrder(string product, int quantity)
        {
            _orderService.PlaceOrder(product, quantity);
        }
    }
}

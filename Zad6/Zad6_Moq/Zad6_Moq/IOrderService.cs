using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6_Moq
{
    public interface IOrderService
    {
        void PlaceOrder(string product, int quantity);
    }
}

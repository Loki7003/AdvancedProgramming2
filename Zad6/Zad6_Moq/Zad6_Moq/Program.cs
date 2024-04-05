using System;
using Moq;
using Zad6_Moq;

internal class Program
{
    private static void Main(string[] args)
    {
        int productsQuantity;
        Console.WriteLine("How many products would you like to order?\n(Default value is 1.)");
        bool isInt = int.TryParse(Console.ReadLine(), out productsQuantity);
        
        if (!isInt)
        {
            productsQuantity = 1;
        }


        var orderService = new Mock<IOrderService>();
        orderService.Setup(os => os.PlaceOrder(It.IsAny<string>(), It.IsAny<int>()));

        var orderProcessor = new OrderProcessor(orderService.Object);

        for(int i = 0; i < productsQuantity; i++)
        {
            Console.WriteLine("Enter product name:");
            string product = Console.ReadLine();

            int quantity;
            Console.WriteLine($"Enter quantity of {product}:\n(Default value is 1.)");
            isInt = int.TryParse(Console.ReadLine() , out quantity);
            
            if (!isInt)
            {
                quantity = 1;
            }

            orderProcessor.ProcessOrder(product, quantity);

            Console.WriteLine($"Order for {quantity} of {product} has been processed.");
        }
        
    }
}
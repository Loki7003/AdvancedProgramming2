using Zad5_Moq;
using Moq;

internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;

        Console.WriteLine("Enter first number:");
        int.TryParse(Console.ReadLine(), out a);

        Console.WriteLine("Enter second number:");
        int.TryParse(Console.ReadLine(), out b);

        var webService = new Moq.Mock<IWebService>();
        webService.Setup(ws => ws.SendData(It.IsAny<string>()));

        var calculator = new Calculator(webService.Object);
        int result = calculator.Add(a, b);

        Console.WriteLine($"The result is: {result}");
    }
}
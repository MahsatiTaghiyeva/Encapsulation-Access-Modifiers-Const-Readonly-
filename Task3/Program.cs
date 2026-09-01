using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.Write("Enter first number: ");

        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Invalid number!");
            return;
        }

        calculator.Num1 = num1;

        Console.Write("Enter operation (+, -, *, /): ");
        calculator.Operation = Console.ReadLine();

        Console.Write("Enter second number: ");

        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Invalid number!");
            return;
        }

        calculator.Num2 = num2;

        Console.WriteLine($"Result: {calculator.Calculate()}");
    }
}
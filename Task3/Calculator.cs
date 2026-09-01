using System;
public class Calculator
{
    public int Num1 {get; set;}
    public int Num2 {get; set;}
    private string _operation;
    public string Operation
    {
        get  => _operation;
        set
        {
            if(value == "*"||value == "/"||value == "+"||value == "-")
                _operation = value;
            else
                Console.WriteLine("Invalid Operation!");
        }
    }
    public int Calculate()
    {
        int result;
        switch (_operation)
        {
            case "*": 
                result = Num1*Num2;
                break;
            case "/":
                if(Num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return 0;
                }
                result = Num1 / Num2;
                break;
            case "+":
                result = Num1 + Num2;
                break;

            case "-":
                result = Num1 - Num2;
                break;

            default:
                Console.WriteLine("Invalid Operation!");
                return 0; }
            return result;
    }
}
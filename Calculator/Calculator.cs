using System;

namespace net_3
{
    public class Calculator
    {
        public void Options()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("\t + : Add");
            Console.WriteLine("\t - : Subtract");
            Console.WriteLine("\t * : Multiply");
            Console.WriteLine("\t / : Divide");
        }

        public string Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "*":
                    return string.Format($"Your result: {num1} {operation} {num2} = {num1 * num2}");

                case "+":
                    return string.Format($"Your result: {num1} {operation} {num2} = {num1 + num2}");

                case "-":
                    return string.Format($"Your result: {num1} {operation} {num2} = {num1 - num2}");

                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return string.Format($"Your result: {num1} {operation} {num2} = {num1 / num2}");

                default:
                    return "That was not a valid option";
            }
        }
    }
}

using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rez;
            string value;
            do
            {
                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter one of the symbols (+,-,*,/,%):");
                string symbol = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case "+":
                        rez=num1+num2;
                        Console.WriteLine("Adition " + rez);
                        break;
                    case "-":
                        rez=num1-num2;
                        Console.WriteLine("Substraction " + rez);
                        break;
                    case "*":
                        rez=num1*num2;
                        Console.WriteLine("Multiplication " + rez);
                        break;
                    case "/":
                        rez=num1/num2;
                        Console.WriteLine("Division " + rez);
                        break;
                    /*case "%":
                        rez=num1%num2;
                        Console.WriteLine("Modulo" + rez);
                        break;*/
                    default: Console.WriteLine("Wrong input");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                value = Console.ReadLine(); 
                
            } while(value == "y" || value == "Y") ;
        }
    }
}
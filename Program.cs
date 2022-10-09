using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var action = 0;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Please enter a valid input.");
                    continue;
                }
                else if (action > 4 || action < 0)
                {
                    Console.WriteLine("Please enter 1 for addition, 2 for subtraction, 3 for multiplication, or 4 for division.");
                    continue;
                }
                break;
            }

            var calculator = new Calculator();

            switch (action)
            {
                case 1:
                    var success = GetNumbers("add", out int num1, out int num2);
                    if (success)
                    {
                    Console.Write($"{num1} + {num2} = ");
                    Console.Write(calculator.Add(num1, num2)) ;

                    }
                    break;

                case 2:
                    success = GetNumbers("subtract", out int subnum1, out int subnum2);
                    if (success)
                    {
                        Console.Write($"{subnum1} - {subnum2} = ");
                        Console.Write(calculator.Subtract(subnum1, subnum2));
                    }
                    break;

                case 3:
                    success = GetNumbers("multiply", out int multNum1, out int multNum2);
                    if (success)
                    {
                        Console.Write($"{multNum1} * {multNum2} = ");
                        Console.Write(calculator.Multiply(multNum1, multNum2));
                    }
                    break;

                case 4:
                   success = GetNumbers("divide", out int divNum1, out int divNum2);
                    if (success){
                        Console.Write($"{divNum1} / {divNum2} = ");
                        Console.Write(calculator.Divide(divNum1, divNum2));
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        static bool GetNumbers(string method, out int num1, out int num2)
        {
            Console.WriteLine("Enter two numbers to " + method);
            Console.Write("Number 1: ");
            var number1 = Console.ReadLine();
            Console.Write("Number 2: ");
            var number2 = Console.ReadLine();

            

            if (int.TryParse(number1, out int number1Temp) && int.TryParse(number2, out int number2Temp))
            {
                num1 = number1Temp;
                num2 = number2Temp;
                return true;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                num1 = 0;
                num2 = 0;
                return false;
            }

        }
    }
}
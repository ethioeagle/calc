using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            int ops;

            Console.Write("Enter the First Number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number:");
            num2 = int.Parse(Console.ReadLine());
            //result = Add(num1, num2);
            //Console.WriteLine("The result is :" + result);
            //Console.ReadLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Please select one of the above Operation 1 for Addition, 2 for subtraction, 3 for Multiplication, 4 for Division");

            ops =int.Parse(Console.ReadLine());

            if (ops == 1)
            {
                result = Add(num1, num2);
            }
            else if (ops == 2)
            {
                result = Subtraction(num1, num2);
            }
            else if (ops == 3)
            {
                result = Multiplication(num1, num2);
            }
            else if (ops == 4)
            {
                result = Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Please enter numbers from 1 to 4");
                result = 0;
            }
            Console.WriteLine("The result is : " + result);
            Console.ReadLine();
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }
        static int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
        static int Division(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Please Enter correct num1");
                return n1;
            }
            else
                return n1 / n2;

        }
    }
}

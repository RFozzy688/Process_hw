using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task_3_app");

            if (args.Length < 2)
            {
                Console.WriteLine("Wrong arguments!!!");
                Console.ReadKey();
                return;
            }

            double result = 0;
            char action = ' ';
            double[] numbers = new double[2];
            int i = 0;

            foreach (var el in args)
            {
                if (el == "+")
                {
                    action = '+';
                }
                else if (el == "*")
                {
                    action = '*';
                }
                else if (el == "-")
                {
                    action = '-';
                }
                else if (el == "/")
                {
                    action = '/';
                }
                else
                {
                    numbers[i] = Double.Parse(el);
                    i++;
                }
            }

            switch (action)
            {
                case '+':
                    result = numbers[0] + numbers[1];
                    break;
                case '-':
                    result = numbers[0] - numbers[1];
                    break;
                case '*':
                    result = numbers[0] * numbers[1];
                    break;
                case '/':
                    result = numbers[0] / numbers[1];
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Result = {result}");
            Console.ReadKey();
        }
    }
}

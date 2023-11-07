using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Love_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, counter = 1, endPointCount = 3, factor1_of_x = 2, factor2_of_x = 5;
            double result = 0;
            bool control1 = true, control2 = true;
            Console.Write("Please enter a number between 2 and 50: ");
            string str_x = Console.ReadLine();
            Console.WriteLine();
            while (control1)
            {
                while (!(int.TryParse(str_x, out x)))
                {
                    Console.Write("Enter a number between 2 and 50: ");
                    str_x = Console.ReadLine();
                    Console.WriteLine();
                }
                if (!(x >= 2 && x <= 50))
                {
                    Console.Write("Enter a number between 2 and 50: ");
                    str_x = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    control1 = false;
                }
            }


            Console.Write("Please enter a number between 25 and 30: ");
            string str_y = Console.ReadLine();
            Console.WriteLine();
            while (control2)
            {
                while (!(int.TryParse(str_y, out y)))
                {
                    Console.Write("Enter a number between 25 and 30: ");
                    str_y = Console.ReadLine();
                    Console.WriteLine();
                }
                if (!(y >= 25 && y <= 30))
                {
                    Console.Write("Enter a number between 25 and 30: ");
                    str_y = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    control2 = false;
                }
            }


            Console.Write("Please choose an operator, you can choose either \'*\' or \'+\': ");
            string delta = Console.ReadLine();
            Console.WriteLine();
            while (!(delta == "*" || delta == "+"))
            {
                Console.Write("Please enter just \'*\' or \'+\':");
                delta = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < 25; i++)
            {
                double min = 0, numeratorPart1 = 0, numeratorPart2 = y, denominator = 0;
                if (delta == "*")
                {
                    numeratorPart1 = (factor1_of_x * x) * (factor2_of_x * x);
                }
                else
                {
                    numeratorPart1 = (factor1_of_x * x) + (factor2_of_x * x);
                }
                factor1_of_x += 3;
                factor2_of_x += 3;


                for (int j = 1; j < y - i; j++)
                {
                    numeratorPart2 *= numeratorPart2;
                }

                min = numeratorPart1;
                if (numeratorPart2 < min)
                {
                    min = numeratorPart2;
                }


                for (int k = counter; k < endPointCount; k++)
                {
                    double denomPowCalculation = 1;
                    if (i == 0)
                    {
                        denominator += (2 * k - 1);
                    }
                    else
                    {
                        for (int l = 0; l <= i; l++)
                        {
                            denomPowCalculation *= (2 * k - 1);
                        }
                        denominator += denomPowCalculation;
                    }
                }
                counter++;
                endPointCount += 2;

                if (i == 0)
                {
                    result += min / denominator;
                }
                else if (i % 2 == 1)
                {
                    result += min / denominator;
                }
                else if (i % 2 == 0)
                {
                    result -= min / denominator;
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}

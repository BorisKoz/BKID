using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Кожуро Борис ИУ5-35Б";
            double a = 0, b = 0, c = 0;
            if (args.Length == 3)
            {
                try
                {
                    a = Double.Parse(args[0]);
                    b = Double.Parse(args[1]);
                    c = Double.Parse(args[2]);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициенты некорректны!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    a = ReadCoefficient("Введите А");
                    b = ReadCoefficient("Введите B");
                    c = ReadCoefficient("Введите С");
                }
            }
            else
            {
                a = ReadCoefficient("Введите А");
                b = ReadCoefficient("Введите B");
                c = ReadCoefficient("Введите С");
            }
            Console.WriteLine("{0} {1}*x^2 + {2}*x + {3}", "Уравнение:", a, b, c);
            double X;
            if (a == 0 && b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Коэффициенты равны 0");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (a == 0 && b != 0)
            {
                X = -b / c;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} :  {1}", "Единственный корень", X);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                double D = (Math.Sqrt(Math.Pow(b, 2.0) - (4 * a * c)));
                if ((Math.Pow(b, 2.0) - 4 * a * c) < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корни комплексные");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (D == 0)
                {
                    X = -b / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} :  {1}", "Единственный корень", X);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine(D);
                    X = (-b + D) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} :  {1}", "Корень 1", X);
                    Console.WriteLine("{0} :  {1}", "Корень 2", (-b - D) / (2 * a));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.ReadKey();

        }


        static double ReadCoefficient(string Message)
        {
            double Coefficient = 0;
            string ReadLine;
            bool check;
            Console.WriteLine(Message);
            ReadLine = Console.ReadLine();
            do
            {
                if (!(check = double.TryParse(ReadLine, out Coefficient)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверно введено число!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    ReadLine = Console.ReadLine();
                }
            } while (!check);

            return Coefficient;
        }

    }
}

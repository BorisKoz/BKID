using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    // делегат мат. операции, возможно - с модулем.
    delegate void Calc(string s, int i1, int i2, bool abs);
    class Program
    {
        //просто умножение, умеющее возвращать модуль
        static void multiply(string str, int a, int b, bool abs)
        {
            Console.Write(str);
            if (abs)
                Console.WriteLine(Math.Abs(a * b));
            else
                Console.WriteLine(a * b);
        }
        // печать при вызове делегатом
        static void Print(int a, int b, bool ab, string str, Calc func)
        {
            Console.WriteLine("Параметры: a = " + a.ToString() + ", b = " + b.ToString());
            Console.Write("Результат:" );
            func(str, a, b, ab);
        }
        // печать обобщ. делегатом
        static void Print2(int a, int b, bool ab, string str, Action<string, int, int, bool> act_param)
        {
            Console.WriteLine("Параметры: a = " + a.ToString() + ", b = " + b.ToString());
            act_param(str, a, b, true);
        }

        static void Main(string[] args)
        {
            // метод с делегатом
            Print(5, -10, true, "Умножение", multiply);
            // метод с делегатом на лямда-функции
            Print(-10, 5, false, "Сумма",
            (str, a, b, abs) =>
                {
                    Console.Write(str);
                    if (abs)
                        Console.WriteLine(Math.Abs(a + b));
                    else
                        Console.WriteLine(a + b);
                }
            );
            // создание 2 делегатов на лямда-выражениях, те же сумма и умножение
            Action<string, int, int, bool> act1 = (str, a, b, abs) =>
            {
                Console.Write(str);
                if (abs)
                    Console.WriteLine(Math.Abs(a + b));
                else
                    Console.WriteLine(a + b);
            };
            Action<string, int, int, bool> act2 = (str, a, b, abs) =>
            {
                Console.Write(str);
                if (abs)
                    Console.WriteLine(Math.Abs(a * b));
                else
                    Console.WriteLine(a * b);
            };
            // обобщённый делегат
            Action<string, int, int, bool> chain = act1 + act2;
            // вызов через action
            Print2(-5, 10, true, "сумма или умножение по модулю: ", chain);
            Console.ReadKey();
        }
    }
}

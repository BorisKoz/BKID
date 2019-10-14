using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Кожуро Борис ИУ5-35Б";
            rectangle figure_1 = new rectangle(3.2, 10);
            figure_1.Print();
            square figure_2 = new square(11);
            figure_2.Print();
            circle figure_3 = new circle(100);
            figure_3.Print();
            string pause = Console.ReadLine();
        }
    }
}

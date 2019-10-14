using System;

namespace Lab_2
{
    public class square : rectangle, IPrint
    {
        public square(double side) : base (side, side)
        {
            this.type = "Квадрат";
        }
        public void Print ()
        {
            Console.WriteLine("сторона " + this.width);
            Console.WriteLine(this.ToString());
        }
    }
}
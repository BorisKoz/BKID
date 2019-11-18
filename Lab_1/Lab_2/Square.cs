using System;

namespace Lab_2
{
    public class square : rectangle, IPrint
    {
        public square(double side) : base (side, side)
        {
            this.type = "Квадрат";
        }
        public override string ToString()
        {
            return "Фигура: " + this.type + " " + this.width + "; площадь равна: " + area().ToString("F2");
        }
        new public void Print ()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
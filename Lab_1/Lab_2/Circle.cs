using System;

namespace Lab_2
{
    public class circle : abstract_figure, IPrint
    {
        private double figure_radius;
        public double radius
        {
            get { return this.figure_radius; }
            set { this.figure_radius = value; }
        }
        public circle(double radius) 
        {
            this.radius = radius;
            this.type = "Круг";
        }
        public override double area()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return "Фигура: " + this.type + " " + this.radius + "; площадь равна: " + area().ToString("F2");
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
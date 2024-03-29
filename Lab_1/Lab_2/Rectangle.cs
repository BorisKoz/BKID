﻿using System;

namespace Lab_2 {
    public class rectangle : abstract_figure, IPrint
    {
        private double figure_width;
        private double figure_height;
        public double width
        {
            get { return this.figure_width; }
            set { this.figure_width = value; }
        }
        public double height
        {
            get { return this.figure_height; }
            set { this.figure_height = value; }
        }
        public rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;
            this.type = "Прямоугольник";
        }
        override public double area()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            return "Фигура: " + this.type  + " " + this.width  + " " + this.height + "; площадь равна: " + area().ToString("F2");
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

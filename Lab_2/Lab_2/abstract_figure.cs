using System;

namespace Lab_2
{
    public abstract class abstract_figure
    {
        private string figure_type;
        public string type
        {
            get { return this.figure_type; }
            set { this.figure_type = value; }
        }
        public abstract double area();
        public override string ToString()
        {
            return "Фигура: " + this.type + "; площадь равна: " + area().ToString();
        }
    }
}
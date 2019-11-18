using System;

namespace Lab_2
{
    public abstract class abstract_figure : IComparable
    {
        private string figure_type;
        public string type
        {
            get { return this.figure_type; }
            set { this.figure_type = value; }
        }
        public abstract double area();
       
        public int CompareTo(object obj)
        {
            abstract_figure f = (abstract_figure)obj;
            if (f.area() == this.area())
            {
                return 0;
            }
            else if (f.area() > this.area())
            {
                return -1;
            }
            return 1;
        }
    }
}
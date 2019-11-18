using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;
using SparseMatrix;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle(10, 10);
            circle circ = new circle(20);
            square sqr = new square(15);
            ArrayList figures_array_list = new ArrayList();
            figures_array_list.Add(rect);
            figures_array_list.Add(circ);
            figures_array_list.Add(sqr);
            Console.WriteLine("ArrayList:");
            for (int i = 0; i < figures_array_list.Count; i++)
            {
                Console.WriteLine(figures_array_list[i].ToString());
            }
            figures_array_list.Sort();
            Console.WriteLine("Sorted:");
            for (int i = 0; i < figures_array_list.Count; i++)
            {
                Console.WriteLine(figures_array_list[i].ToString());
            }
            List<abstract_figure> figure_list_t = new List<abstract_figure> ();
            figure_list_t.Add(circ);
            figure_list_t.Add(rect);
            figure_list_t.Add(sqr);
            Console.WriteLine("List<T>");
            foreach (var i in figure_list_t)
            {
                Console.WriteLine(i.ToString());
            }
            figure_list_t.Sort();
            Console.WriteLine("Sorted:");
            foreach (var i in figure_list_t)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("3d Sparse-matrix:");
            Matrix <abstract_figure> figure_matrix = new Matrix<abstract_figure>(10, 10, 10, null);
            figure_matrix[1, 1, 1] = circ;
            figure_matrix[9, 0, 9] = sqr;
            figure_matrix[6, 9, 1] = rect;
            Console.Write(figure_matrix.ToString());
            Console.WriteLine("Stack:");
            SimpleStack<abstract_figure> figure_stack = new SimpleStack<abstract_figure>();
            figure_stack.push(circ);
            figure_stack.push(rect);
            figure_stack.push(sqr);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(figure_stack.pop().ToString());
            }
            Console.ReadKey();
        }
    }
}

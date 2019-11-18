using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleListProject;

namespace Lab_3
{
    public class SimpleStack<T> : SimpleList <T> 
        where T : IComparable 
    {

        public void push (T obj)
        {
            this.Add(obj);
        }
        public T pop ()
        {
            T to_return = Get(Count - 1);
            if (Count != 1)
            {
                last = GetItem(Count - 2);
            }
            Count--;
            return to_return;
        }
    }
}

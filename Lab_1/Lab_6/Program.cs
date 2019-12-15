using System;
using System.Reflection;
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
        #region часть 1
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

        #endregion
        #region Часть 2
        public class test_class
        {
            //attr
            [test_attribute("attribute of y")]
            public int y { get { return y; } set { y = value; } }
            // конструкторы
            public test_class()
            {
                x = 1; _y = 1;
            }
            public test_class(int px) : this()
            {
                x = px;
            }
            public test_class(int px, int py) : this(px)
            {
                _y = py;
            }
           //метод
            public int sum() {
                Console.WriteLine("вызван метод sum");
                return x+_y;
            }
            // поля данных
            public int x;
            // не видно, т.к. private
            private int _y;
        }
        public class test_attribute : System.Attribute
        {
            public test_attribute() { }
            public test_attribute(string pdescription)
            {
                Description = pdescription;
            }

            public string Description { get; set; }
        }

        public static bool attributes_used(PropertyInfo check_type, Type atr_type, out object atr)
        {
            bool result = false;
            atr = null;
            var is_atr = check_type.GetCustomAttributes(atr_type, false);
            if (is_atr.Length > 0)
            {
                result = true;
                atr = is_atr[0];
            }
            return result;
        }
        static void invoke_method()
        {
            Type t = typeof(test_class);
            Console.WriteLine("\nВызов метода через рефлексию:");
            //Создание объекта через рефлексию
            test_class test = (test_class)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            object[] parameter = new object[] {  };
            //Вызов метода
            object result = t.InvokeMember("sum", BindingFlags.InvokeMethod, null, test, null);
        }
        static void attributes_in_class()
        { 
            Type t = typeof(test_class);
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object atr_obj;
                if (attributes_used(x, typeof(test_attribute), out atr_obj))
                {
                    test_attribute atr1 = atr_obj as test_attribute;
                    Console.WriteLine(x.Name + " - " + atr1.Description);
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1");
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


            Console.WriteLine("Часть 2");
            Console.WriteLine("");

            test_class obj = new test_class();
            Type t = obj.GetType();

            Console.WriteLine("Тип: " + t.FullName);
            Console.WriteLine("Пространство имён: " + t.Namespace);
            Console.WriteLine("Информация о сборке: " + t.AssemblyQualifiedName);
            Console.WriteLine("Конструкторы: ");
            foreach (var x in t.GetConstructors()) Console.WriteLine(x);
            Console.WriteLine("Методы: ");
            foreach (var x in t.GetMethods()) Console.WriteLine(x);
            Console.WriteLine("Свойства: ");
            foreach (var x in t.GetProperties()) Console.WriteLine(x);
            Console.WriteLine("Поля данных: ");
            foreach (var x in t.GetFields()) Console.WriteLine(x);

            attributes_in_class();
            invoke_method();
            Console.ReadKey();
        }
    }
}

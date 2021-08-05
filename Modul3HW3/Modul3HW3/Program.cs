using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();

            class1.ShowHandler += Show;
            class1.ShowHandler.Invoke(class2.Calc(class1.Pow, 3, 4).Invoke(2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя кота: ");
            string str = Console.ReadLine();
            Cat cat = new Cat(str);
            cat.ShowInfo();
            Console.WriteLine("Введите имя собаки: ");
            string str1 = Console.ReadLine();
            Dog dog = new Dog(str1);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}

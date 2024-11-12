using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Animal
    {
       
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Name = "Маруся";
            }
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("{0}",Name);
            Say();
        }
    }
}

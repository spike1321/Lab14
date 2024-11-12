using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Cat : Animal
    {
        private string name;
       // private string say;
        public override string Name 
        { 
            get => name;
            set => name = value; 
        }
        public Cat(string name_)
            : base(name_)
        { 
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}

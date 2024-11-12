using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Dog:Animal
    {
        private string name;
       // private string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name_)
            : base(name_)
        {
            //this.say = say_;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}

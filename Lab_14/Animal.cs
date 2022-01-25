using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string say;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat(string name, string say)
            : base(name)

        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }

    class Dog : Animal
    {
         string say;
         string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string say)
            : base(name)

        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine("Гав-гав");
        }

    }









}

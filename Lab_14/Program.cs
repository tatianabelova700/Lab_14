using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat cat = new Cat("Милош", "Мяу");
            cat.ShowInfo();

            Dog dog = new Dog("Бим", "Гав - гав");
            dog.ShowInfo();
            Console.ReadKey();
        }
        
    }
}

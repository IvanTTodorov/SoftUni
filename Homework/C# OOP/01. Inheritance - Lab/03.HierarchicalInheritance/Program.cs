using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();



        }
    }
}
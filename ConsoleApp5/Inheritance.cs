using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an animal");
        }


    }
    class Dog : Animal
    {
        public void getname()
        {
            Console.WriteLine("My name is " + name);
        }
    }
    class Program1
    {
        static void Main (string[] args)
        {
            Dog labrador = new Dog();
            labrador.name = "Rohu";
            labrador.display();


            labrador.getname();
            Console.ReadLine();

        }


    }

}

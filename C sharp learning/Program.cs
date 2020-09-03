using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    class Animal
   {
       public string Name { get; set; }
       public Animal(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Dog :  Animal
    {
        private float speed;
       public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;          
          
        }
    }

    class Cat : Animal
    {
        private float speed;
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;

        }
    }


    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "Alex"));
            animals.Add(new Dog(44.13f, "Sam"));
            animals.Add(new Cat(11.11f, "Godlike"));

            foreach (Animal animal in animals)
            {
                if(animal is Animal)
                   Console.WriteLine(animal.Name);

                if (animal is Cat)
                    (animal as Cat).Print();
            }  

            //Dog tom = new Dog(12.23f, "Tom" );
            //Console.WriteLine(tom.Name);

            //Dog jerry = new Dog(23.25f, "Jerry");
            //jerry.Name = "Jerry";
           
            //Console.WriteLine();
            //Console.WriteLine(jerry.Name);
            //jerry.Print();
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    abstract class Animal
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Animal(String Name, int Age) 
        {
            this.Name = Name;
            this.Age = Age;
        }

        public abstract void MakeSound();
       
    }

    class Dog : Animal
    {
        public Dog(String Name , int Age) : base(Name, Age) { }
         public override void  MakeSound()
        {
            Console.WriteLine($"{Name} the dog barks: woof!");
        }
    }

    class Cat : Animal
    {
        public Cat(String Name, int Age) : base(Name, Age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the cat meows: Meow!");
        }
    }

    class Bird : Animal
    {
        public Bird(String Name, int Age) : base(Name, Age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the bird chirps: tweet!");
        }
    }


}

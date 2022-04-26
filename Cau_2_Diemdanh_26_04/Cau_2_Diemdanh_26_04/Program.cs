using System;

namespace Cau_2_Diemdanh_26_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.eat();
            cat.makeSound();
            cat.run();
            Bird bird = new Bird();
            bird.eat();
            bird.makeSound();
            bird.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Thuc an");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo di bon chan");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an ca");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo meo meo");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay  tren troi");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an bot");
        }
        public override void makeSound()
        {
            Console.WriteLine("chip chip chip");
        }
    }
}
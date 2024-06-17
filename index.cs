using System;

namespace OOPConcepts
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Interface IMovable
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Console.WriteLine("Inheritance and Method Overriding:");
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();
            genericAnimal.MakeSound(); // Outputs: Some generic sound
            dog.MakeSound();           // Outputs: Bark
            cat.MakeSound();           // Outputs: Meow

            Console.WriteLine();

            // Abstract Classes and Methods
            Console.WriteLine("Abstract Classes and Methods:");
            Shape circle = new Circle(5); // Radius = 5
            Shape rectangle = new Rectangle(4, 6); // Width = 4, Height = 6
            Console.WriteLine($"Area of Circle: {circle.GetArea()}"); // Outputs: Area of Circle: 78.54
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Outputs: Area of Rectangle: 24

            Console.WriteLine();

            // Interfaces
            Console.WriteLine("Interfaces:");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();
            car.Move();       // Outputs: Car is moving
            bicycle.Move();   // Outputs: Bicycle is moving
        }
    }
}

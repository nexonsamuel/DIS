using System;
using System.IO;

namespace w3schools
{
    class Program
    {
        string color;
        string maxspeed;

        string writeText = "Hello World!!";
        //File.WriteAllLines(@""C:\Users\Raphael\Desktop\New folder\writeText.txt", writeText);
            
            static void Main(string[] args)
            {

            Car myObj1 = new Car();
            //Console.WriteLine(myObj1.color);
            myObj1.fullThrottle();

            Car Ford = new Car();
            //Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            MyClass c1 = new MyClass();
            Console.WriteLine(c1.color);
            Console.WriteLine(c1.maxSpeed);

            Car Ford1 = new Car("Mustang");
            Console.WriteLine(Ford1.model);

            Car Ford2 = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);

            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Pig2 myPig_2 = new Pig2(); // Create a Pig object
            myPig_2.animalSound();  // Call the abstract method
            myPig_2.sleep();  // Call the regular method

            Pig3 myPig_3 = new Pig3();  // Create a Pig object
            myPig_3.animalSound();

            DemoClass dc = new DemoClass();
            dc.myMethod();
            dc.myOtherMethod();

            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

        }

        enum Level
        {
            Low,
            Medium,
            High
        }


    }

     class Car: Vehicle
    {
        //public string color = "red";
        private string priv_model;
        public string modelName = "Mustang";

        public string model;
        public string color;
        public int year;
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public Car()
        {
            model = "Mustang";
        }

        public Car(string modelName)
        {
            model = modelName;
        }

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        //Car Fords = new Car("Mustang");
        //Console.WriteLine(Fords.priv_model);

    }

    class MyClass
    {
        // Class members
        public string color = "red";        // field
        public int maxSpeed = 200;          // field

    }

    class Person
    {
        private string name; // field
        public string Name2   // property
        {
            get { return name; }
            set { name = value; }
        }

        public string Name  // property
        { get; set; }
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Pig2 : Animal2
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Pig3 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    abstract class Animal2
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class try_catch
    {

        public void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }


    }

}
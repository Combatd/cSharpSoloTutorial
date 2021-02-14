using System;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Inheritance allows us to define a class based on another class. This makes creating and maintaining an application easy.
             The class whose properties are inherited by another class is called the Base class. The class which inherits the properties is called the Derived class.
             For example, base class Animal can be used to derive Cat and Dog classes.
             The derived class inherits all the features from the base class, and can have its own additional features.

             Inheritance allows us to define a class based on another class.
             */

            /*
             Let's define our base class Animal.
             Now we can derive class Dog from it.

             Note the syntax for a derived class.
             A colon and the name of the base class follow the name of the derived class.
             All public members of Animal become public members of Dog.
             That is why we can access the Legs member in the Dog constructor.
             Now we can instantiate an object of type Dog and access the inherited members as well as call its own Bark method.


             A base class can have multiple derived classes. For example, a Cat class can inherit from Animal.



             Inheritance allows the derived class to reuse the code in the base class without having to rewrite it.
             And the derived class can be customized by adding more members.
             In this manner, the derived class extends the functionality of the base class.
             */
        }
    }


    class Animal
    {
        public int Legs { get; set; }
        public int Age { get; set; }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
        }

        public void Bark()
        {
            Console.Write("Woof");
        }
    }

}

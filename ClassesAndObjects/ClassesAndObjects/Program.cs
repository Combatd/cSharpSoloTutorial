using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * As we have seen in the previous modules, built-in data types are used to store a single value in a declared variable. 
             * For example, int x stores an integer value in a variable named x.
               In object-oriented programming, a class is a data type that defines a set of variables and methods for a declared object.
               For example, if you were to create a program that manages bank accounts,
               a BankAccount class could be used to declare an object that would have all the properties and methods needed for managing an individual bank account, such as a balance variable and Deposit and Withdrawal methods.

               A class is like a blueprint.
               It defines the data and behavior for a type.
               A class definition starts with the keyword class followed by the class name.
               The class body contains the data and actions enclosed by curly braces.
             */


            /*
             Just as a built-in data type is used to declare multiple variables, a class can be used to declare multiple objects.
             As an analogy, in preparation for a new building, the architect designs a blueprint, which is used as a basis for actually building the structure.
             That same blueprint can be used to create multiple buildings.
             Programming works in the same fashion. We define (design) a class that is the blueprint for creating objects.
             In programming, the term type is used to refer to a class name: We're creating an object of a particular type.

             Once we've written the class, we can create objects based on that class. Creating an object is called instantiation.

             Each object has its own characteristics.
             Just as a person is distinguished by name, age, and gender, an object has its own set of values that differentiate it from another object of the same type.
             The characteristics of an object are called properties.
             Values of these properties describe the current state of an object.
             For example, a Person (an object of the class Person) can be 30 years old, male, and named Antonio.

             Objects aren't always representative of just physical characteristics.
             For example, a programming object can represent a date, a time, and a bank account.
             A bank account is not tangible; you can't see it or touch it, but it's still a well-defined object because it has its own properties.
             */


            /*
             C# has two ways of storing data: by reference and by value.
             The built-in data types, such as int and double, are used to declare variables that are value types.
             Their value is stored in memory in a location called the stack.
             
             Reference types are used for storing objects. For example, when you create an object of a class, it is stored as a reference type.
             Reference types are stored in a part of the memory called the heap.
             When you instantiate an object, the data for that object is stored on the heap, while its heap memory address is stored on the stack.
             That is why it is called a reference type - it contains a reference (the memory address) to the actual object on the heap.
             */



            /*
             Stack is used for static memory allocation, which includes all your value types, like x.
             Heap is used for dynamic memory allocation, which includes custom objects, that might need additional memory during the runtime of your program.
             */


            /*
             
             class Person
                {
                  int age;
                  string name;
                  public void SayHi()
                  {
                    Console.WriteLine("Hi");
                  }
                }

                The code above declares a class named Person, which has age and name fields as well as a SayHi method that displays a greeting to the screen.
                You can include an access modifier for fields and methods (also called members) of a class. Access modifiers are keywords used to specify the accessibility of a member.
                A member that has been defined public can be accessed from outside the class, as long as it's anywhere within the scope of the class object. That is why our SayHi method is declared public, as we are going to call it from outside of the class.


                You can also designate class members as private or protected
                If no access modifier is defined, the member is private by default.
             */
        }

        class Car
        {
            string color;
            int year;
        }
    }
}

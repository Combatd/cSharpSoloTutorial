using System;

namespace MoreOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             As constructors are used when a class is instantiated, destructors are automatically invoked when an object is destroyed or deleted.
        Destructors have the following attributes:
        - A class can only have one destructor.
        - Destructors cannot be called. They are invoked automatically.
        - A destructor does not take modifiers or have parameters.
        - The name of a destructor is exactly the same as the class prefixed with a tilde (~).


            class Dog
            {
              ~Dog() 
              {
                // code statements
              }
            }
             */


            /*
             Destructors can be very useful for releasing resources before coming out of the program.
             This can include closing files, releasing memory, and so on.
             */



            /*
             Let’s include WriteLine statements in the destructor and constructor of our class and see how the program behaves when an object of that class is created and when the program ends:

             This can be useful, for example, if your class is working with storage or files.
             The constructor would initialize and open the files. Then, when the program ends, the destructor would close the files.
             */

            Dog d = new Dog();

        }

        class Dog
        {
            public Dog()
            {
                Console.WriteLine("Constructor");
            }
            ~Dog()
            {
                Console.WriteLine("Destructor");
            }
        }
    }
}

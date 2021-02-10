using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A method is a group of statements that perform a particular task.
                In addition to the C# built-in methods, you may also define your own.

               Methods have many advantages, including:
                - Reusable code.
                - Easy to test.
                - Modifications to a method do not affect the calling program.
                - One method can accept many different inputs.
             */

            /*
             Method Declaration

            <return type> name(type1 par1, type2 par2, … , typeN parN)
            {
                List of statements
            }


            int Sqr(int x)
            {
              int result = x*x;
              return result;
            }

             */

            // Write a static method that does not return a value
            static void Greet()
            {
                Console.WriteLine("Welcome");
            }



            /*
             Method declarations can define a list of parameters to work with.
             Parameters are variables that accept the values passed into the method when called.

            void Print(int x) 
            {
              Console.WriteLine(x);
            }

             Parameters behave within the method similarly to other local variables.
             They are created upon entering the method and are destroyed upon exiting the method.

             */

            // Declare a method and call it from Main with the argument 88

            static void func(int x)
            {
                Console.WriteLine(x / 2);
            }

            func(88);
        }
    }
}

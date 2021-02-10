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
            //static void Greet()
            //{
            //    Console.WriteLine("Welcome");
            //}



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

            //static void func(int x)
            //{
            //    Console.WriteLine(x / 2);
            //}

            //func(88);


            /*
             You can have as many parameters as needed for a method by separating them with commas in the definition.


                int Sum(int x, int y)
                {
                   return x+y;
                }

              The Sum method takes two integers and returns their sum.
              This is why the return type of the method is int.
              Data type and name should be defined for each parameter.

             */

            //int Max(int a, int b)
            //{
            //    if (a > b)
            //    {
            //        return a;
            //    } else
            //    {
            //        return b;
            //    }
            //}

            //Console.WriteLine(Max(5, 7));



            /*
             When defining a method, you can specify a default value for optional parameters.
             Note that optional parameters must be defined after required parameters.
             If corresponding arguments are missing when the method is called, the method uses the default values.
             To do this, assign values to the parameters in the method definition, as shown in this example.
             */

            //static int Vol(int x, int y = 3, int z = 1)
            //{
            //    return x * y * z;
            //}

            //Console.WriteLine(Vol(2, 4)); // 8


            /*
             Named arguments free you from the need to remember the order of the parameters in a method call.
             Each argument can be specified by the matching parameter name.

             When calling the method, you can use the parameter names to provide the arguments in any order you like:

             Named arguments use the name of the parameter followed by a colon and the value.

             int res = Area(w: 5, h: 8);
             Console.WriteLine(res);
             */


            // Call #calc using named arguments with values 5 for "from, 99 for "to" and 2 for "step"
            static int calc(int from, int to, int step = 1)
            {
                int res = 0;
                for (int i = from; i < to; i += step)
                {
                    res += 1;
                }
                return res;
            }

            int res = calc(step: 2, to: 99, from: 5);
            Console.WriteLine(res);


        }
    }
}

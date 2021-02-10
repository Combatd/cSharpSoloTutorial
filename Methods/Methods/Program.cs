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
            //static int calc(int from, int to, int step = 1)
            //{
            //    int res = 0;
            //    for (int i = from; i < to; i += step)
            //    {
            //        res += 1;
            //    }
            //    return res;
            //}

            //int res = calc(step: 2, to: 99, from: 5);
            //Console.WriteLine(res);




            /*
             There are three ways to pass arguments to a method when the method is called:
             By value, By reference, and as Output.

             By value copies the argument's value into the method's formal parameter.
             Here, we can make changes to the parameter within the method without having any effect on the argument.

            static void Sqr(int x)
            {
                x = x * x;
            }
            static void Main(string[] args)
            {
                int a = 3;
                Sqr(a);
            
                Console.WriteLine(a);
            }

             */



            /*
             Pass by reference copies an argument's memory address into the formal parameter.
             Inside the method, the address is used to access the actual argument used in the call.
             This means that changes made to the parameter affect the argument.
             To pass the value by reference, the ref keyword is used in both the call and the method definition:

            static void Sqr(ref int x)
            {
                x = x * x;
            }
            static void Main(string[] args)
            {
                int a = 3;
                Sqr(ref a);
            
                Console.WriteLine(a);
            }

            The ref keyword passes the memory address to the method parameter, which allows the method to operate on the actual variable.
             */

            // Swap the values of two arguments by passing references to memory location
            //static void Swap(ref int x, ref int y)
            //{
            //    int temp;
            //    temp = x; // copy value over to temp variable
            //    x = y; // x gets overwritten with the value of y at the same memory address
            //    y = temp; // the y arg gets overwritten with the value of temp at its memory address
            //}



            /*
             Output parameters are similar to reference parameters,
             except that they transfer data out of the method rather than accept data in.
             They are defined using the out keyword.
             The variable supplied for the output parameter need not be initialized since that value will not be used.
             Output parameters are particularly useful when you need to return multiple values from a method.

                static void GetValues(out int x, out int y)
                {
                    x = 5;
                    y = 42;
                }
                static void Main(string[] args)
                {
                    int a, b;
                    GetValues(out a, out b);
                    Console.WriteLine(a+" "+b);
                }

             Similar to the ref keyword, the out keyword is used both when defining the method and when calling it.

             
             */


            // Ask for user input in method and return a value entered using output parameters

            //static void Ask(out string name)
            //{
            //    name = Console.ReadLine();
            //}

            //string nm; // will be assigned a value from an output parameter
            //Ask(out nm);



            /*
              Method overloading is when multiple methods have the same name, but different parameters.
              For example, you might have a Print method that outputs its parameter to the console window:

            void Print(int a)
            {
              Console.WriteLine("Value: "+a);
            }

            The + operator is used to concatenate values. In this case, the value of a is joined to the text "Value: ".
            This method accepts an integer argument only.
            Overloading it will make it available for other types, such as double

            void Print(double a)
            {
              Console.WriteLine("Value: "+a);
            }

            Now, the same Print method name will work for both integers and doubles.

             */


            /*
                When overloading methods, the definitions of the methods must differ from each other by the types and/or number of parameters.
                When there are overloaded methods, the method called is based on the arguments.
                An integer argument will call the method implementation that accepts an integer parameter.
                A double argument will call the implementation that accepts a double parameter.
                Multiple arguments will call the implementation that accepts the same number of arguments.

                        static void Print(int a) {
                            Console.WriteLine("Value: " + a);
                        }
                        static void Print(double a) {
                            Console.WriteLine("Value: " + a);
                        }
                        static void Print(string label, double a) {
                            Console.WriteLine(label + a);
                        }
                        static void Main(string[] args)
                        {
                            Print(11);
                            Print(4.13);
                            Print("Average: ", 7.57);
                        }


                You cannot overload method declarations that differ only by return type.
                The following declaration results in an error.
                int PrintName(int a) { }
                float PrintName(int b) { }
                double PrintName(int c) { }

             */

            // look at member function Print in class Program
            Print(3);



        }

        // This overloaded method will still take the integer and multiply it as it prints to terminal
        static void Print(int a)
        {
            Console.WriteLine(a * a);
        }
        static void Print(double a)
        {
            Console.WriteLine(a + a);
        }
    }
}

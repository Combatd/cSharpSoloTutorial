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


            /*
             Now it's time to discuss the static keyword.
            You first noticed it in the Main method's declaration:

                static void Main(string[] args)

            Class members (variables, properties, methods) can also be declared as static.
            This makes those members belong to the class itself, instead of belonging to individual objects.
            No matter how many objects of the class are created, there is only one copy of the static member.

                class Cat {
                  public static int count=0;
                  public Cat() {
                    count++;
                  }
                }

            In this case, we declared a public member variable count, which is static. The constructor of the class increments the count variable by one.

            No matter how many Cat objects are instantiated, there is always only one count variable that belongs to the Cat class because it was declared static.
             */



            /*
             Because of their global nature, static members can be accessed directly using the class name without an object.

                        class Cat {
                        public static int count=0;
                            public Cat() {
                                count++;
                            }
                        }
                        static void Main(string[] args)
                        {
                            Cat c1 = new Cat();
                            Cat c2 = new Cat();
                            Console.WriteLine(Cat.count);
                        }
            As you can see, we can access the static variable using the class name: Cat.count.
            The count variable is shared between all Cat objects.
            For this class, each time an object is created, the static value is incremented. The program above demonstrates this when 2 is displayed after creating two objects of that class.
             
            You must access static members using the class name.
            If you try to access them via an object of that class, you will generate an error.
             */


            /*
             The same concept applies to static methods.
             Static methods can access only static members.

             The Main method is static, as it is the starting point of any program.
             Therefore any method called directly from Main had to be static.

             */
            Dog.Bark();


            /*
             Constant members are static by definition.

                        class MathClass {
                            public const int ONE = 1;
                        }

                        static void Main(string[] args)
                        {
                            Console.Write(MathClass.ONE);
                        }

            As you can see, we access the property ONE using the name of the class, just like a static member.
            This is because all const members are static by default.

             */


            /*
             Constructors can be declared static to initialize static members of the class.
             The static constructor is automatically called once when we access a static member of the class.


                                class SomeClass {
                                    public static int X { get; set; }
                                    public static int Y { get; set; }
            
                                    static SomeClass() {
                                        X = 10;
                                        Y = 20;
                                    }
                                }
                                static void Main(string[] args)
                                {
                                    Console.WriteLine(SomeClass.X);
                                }

            The constructor will get called once when we try to access SomeClass.X or SomeClass.Y.

             */



            /*
                An entire class can be declared as static.
                A static class can contain only static members.
                You cannot instantiate an object of a static class, as only one instance of the static class can exist in a program.
                Static classes are useful for combining logical properties and methods. A good example of this is the Math class.
                It contains various useful properties and methods for mathematical operations.

                Console.WriteLine(Math.Pow(2, 3));

                You access all members of the Math class using the class name, without declaring an object.

             */

            /*

                Math

                Math.PI the constant PI.
                Math.E represents the natural logarithmic base e.
                Math.Max() returns the larger of its two arguments.
                Math.Min() returns the smaller of its two arguments.
                Math.Abs() returns the absolute value of its argument.
                Math.Sin() returns the sine of the specified angle.
                Math.Cos() returns the cosine of the specified angle.
                Math.Pow() returns a specified number raised to the specified power.
                Math.Round() rounds the decimal number to its nearest integral value.
                Math.Sqrt() returns the square root of a specified number.


                int[] arr = {1, 2, 3, 4};

                Array.Reverse(arr);
                //arr = {4, 3, 2, 1}

                Array.Sort(arr);
                //arr = {1, 2, 3, 4}



                string s1 = "some text";
                string s2 = "another text";

                String.Concat(s1, s2); // combines the two strings

                String.Equals(s1, s2); // returns false



                Console.WriteLine(DateTime.Now);
                Console.WriteLine(DateTime.Today);
            
                Console.WriteLine(DateTime.DaysInMonth(2016, 2));


                The Console class is also an example of a static class. We use its static WriteLine() method to output to the screen, or the static ReadLine() method to get user input.
                The Convert class used to convert value types is also a static class.

             */

            /*
             The this keyword is used inside the class and refers to the current instance of the class,
             meaning it refers to the current object.
             One of the common uses of this is to distinguish class members from other data,
             such as local or formal parameters of a method
             */


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

            public static void Bark()
            {
                Console.WriteLine("Woof");
            }
        }

        class Person
        {
            private string name;
            public Person(string name)
            { // this.name represents the member of the class, whereas name represents the parameter of the constructor.
                this.name = name;
            }
        }
    }
}

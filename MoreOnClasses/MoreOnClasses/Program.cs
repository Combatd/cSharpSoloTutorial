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
    }
}

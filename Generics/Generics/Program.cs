using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Generics allow the reuse of code across different types.
             For example, let's declare a method that swaps the values of its two parameters:

             static void Swap(ref int a, ref int b) {
              int temp = a;
              a = b;
              b = temp;
            }



            Our Swap method will work only for integer parameters. If we want to use it for other types, for example, doubles or strings, we have to overload it for all the types we want to use it with. Besides a lot of code repetition, it becomes harder to manage the code because changes in one method mean changes to all of the overloaded methods.
            Generics provide a flexible mechanism to define a generic type.


            static void Swap<T>(ref T a, ref T b) {
              T temp = a;
              a = b;
              b = temp;
            }


            In the code above, T is the name of our generic type.
            We can name it anything we want, but T is a commonly used name.
            Our Swap method now takes two parameters of type T.
            We also use the T type for our temp variable that is used to swap the values.


            Note the brackets in the syntax <T>, which are used to define a generic type.


             */



            /*
             * Now, we can use our Swap method with different types, as in:
          
        
                   static void Swap<T>(ref T a, ref T b) {
                    T temp = a;
                    a = b;
                    b = temp;
                }
                static void Main(string[] args)
                {
                    int a = 4, b = 9;
                    Swap<int>(ref a, ref b);
                    Console.WriteLine(a+" "+b);
            
                    string x = "Hello";
                    string y = "World";
                    Swap<string>(ref x, ref y);
                    Console.WriteLine(x+" "+y);
                }


                When calling a generic method, we need to specify the type it will work with by using brackets.
                So, when Swap<int> is called, the T type is replaced by int. For Swap<string>, T is replaced by string.
                If you omit specifying the type when calling a generic method, the compiler will use the type based on the arguments passed to the method.


                Multiple generic parameters can be used with a single method.
                For example:    Func<T, U> takes two different generic types.
             */

            double x = 7.42;
            string y = "test";
            Func(x, y);


            /*
             Generic types can also be used with classes.
            The most common use for generic classes is with collections of items, where operations such as adding and removing items from the collection are performed in basically the same way regardless of the type of data being stored. One type of collection is called a stack. Items are "pushed", or added to the collection, and "popped", or removed from the collection.
            A stack is sometimes called a Last In First Out (LIFO) data structure.

            The generic class stores elements in an array.
            As you can see, the generic type T is used as the type of the array,
            the parameter type for the Push method, and the return type for the Pop and Get methods.


            We can also use the generic class with custom types, such as the custom defined Person type.


            In a generic class we do not need to define the generic type for its methods,
            because the generic type is already defined on the class level.

             */

            Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            // Stack<Person> PersonStack = new Stack<Person>();

        }

        static void Func<T, U> (T x , U y)
        {
            Console.WriteLine(x + " " + y);
        }

        class Stack<T>
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item)
            {
                innerArray[index++] = item;
            }
            public T Pop()
            {
                return innerArray[--index];
            }
            public T Get(int k) { return innerArray[k]; }
        }

        // Define generic class Store with generic data member x that is initialized in constructor
        class Store <T>
        {
            T x;
            public Store(T val)
            {
                x = val;
            }
        }

    }
}

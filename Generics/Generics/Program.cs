using System;
using System.Collections.Generic;

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

            //double x = 7.42;
            //string y = "test";
            //Func(x, y);


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

            //Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            // Stack<Person> PersonStack = new Stack<Person>();

            // Generic class methods are called the same as for any other object:

            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1)); // 6




            /*
             A collection is used to group related objects.
            Unlike an array, it is dynamic and can also group objects.
            A collection can grow and shrink to accommodate any number of objects.
            Collection classes are organized into namespaces and contain built in methods for processing elements within the collection.

            A collection organizes related data in a computer so that it can be used efficiently.
            Different kinds of collections are suited to different kinds of applications, and some are highly specialized to specific tasks.
            For example, Dictionaries are used to represent connections on social websites (such as Twitter, Facebook), queues can be used to create task schedulers, HashSets are used in searching algorithms, etc.

            A collection typically includes methods to add, remove, and count objects.
            The for statement and the foreach statement are used to iterate through collections.
            Since a collection is a class you must first declare an instance of the class before you can add elements to that collection.

            List<int> li = new List<int>();

            Collections provide a more flexible way to work with groups of objects.
            Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change.
             */



            /*
             Generic collections are the preferred type to use as long as every element in the collection is of the same data type. Only desired data types can be added to a generic collection and this is enforced by using strong typing which reduces the possibility of errors.
                The .NET Framework provides a number of generic collection classes, useful for storing and manipulating data.
                The System.Collections.Generic namespace includes the following generic collections:
                - List<T>
                - Dictionary<TKey, TValue>
                - SortedList<TKey, TValue>
                - Stack<T>
                - Queue<T>
                - Hashset<T>

            To access a generic collection in your code, you will need to include the statement: using Systems.Collections.Generic;
             */

            /*
             Non-generic collections can store items that are of type Object. Since an Object data type can refer to any data type, you run the risk of unexpected outcomes. Non-generic collections may also be slower to access as well as execute.
            The System.Collections namespace includes the following non-generic collections:
            - ArrayList
            - SortedList
            - Stack
            - Queue
            - Hashtable
            - BitArray


            Because non-generic collections are error prone and less performant, it is recommended to always use generic collections from the System.Collections.Generic namespace if available and to avoid using legacy collections from the System.Collections namespace.

             */


            /*
             A list is similar to an array, but the elements in a list can be inserted and removed dynamically.
            The C# generic collection List<T> class requires all elements be of the same type T.

            List<T> properties and methods include:
            Count A property that gets the number of elements contained in the list.
            Item[int i] Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the index value inside the brackets.
            Add(T t) Adds an element t to the end of the list.
            RemoveAt(int index) Removes the element at the specified position (index) from the list.
            Sort() Sorts elements in the list.


            Additional List<T> properties and methods are listed below. Try them out by adding them to the List<T> example code above.

            Capacity - A property that gets the number of elements the list can hold before needing to be resized.

            Clear() - Removes all the elements from the list.

            TrimExcess() - Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead.

            AddRange(IEnumerable coll) - Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable is the collections interface that supports simple iteration over the collection.

            Insert(int i, T t) - Inserts an element t at a specific index i in the list.

            InsertRange(int i, IEnumerable coll) - Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections interface that supports simple iteration over the collection.

            Remove(T t) - Removes the first occurrence of the object t from the list.

            RemoveRange(int i, int count) - Removes a specified number of elements count from the list starting at a specified index i.

            Contains(T t) - Returns true if the specified element t is present in the list.

            IndexOf(T t) - Returns the index of the first occurrence of the element t in the list.

            Reverse() - Reverses the order of the elements in the list.

            ToArray() - Copies the elements of the list into a new array.

            Run the code and see how it works!
Remember, you need to include the statement: using Systems.Collections.Generic; to use List<T>.

             */


            List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.RemoveAt(1); // remove 72

            Console.Write("\nList: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 59  95  5  9
            li.Sort();
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 5  9  59  95

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

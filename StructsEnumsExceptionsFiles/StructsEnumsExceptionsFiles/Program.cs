﻿using System;

namespace StructsEnumsExceptionsFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             A struct type is a value type that is typically used to encapsulate small groups of related variables, such as the coordinates of a rectangle or the characteristics of an item in an inventory.
             The following example shows a simple struct declaration:

             struct Book {
              public string title;  
              public double price;
              public string author;
            }


            Structs share most of the same syntax as classes, but are more limited than classes.
            Unlike classes, structs can be instantiated without using a new operator.


            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";


            Structs do not support inheritance and cannot contain virtual methods.

             */



            /*
             Structs can contain methods, properties, indexers, and so on. Structs cannot contain default constructors (a constructor without parameters), but they can have constructors that take parameters.
             In that case the new keyword is used to instantiate a struct object, similar to class objects.




                     struct Point {
                        public int x;
                        public int y;
                        public Point(int x, int y) {
                            this.x = x;
                            this.y = y;
                        }
                    }
                    static void Main(string[] args)
                    {
                        Point p = new Point(10, 15);
                        Console.WriteLine(p.x);
                    }


             In general, classes are used to model more complex behavior, or data, that is intended to be modified after a class object is created. Structs are best suited for small data structures that contain primarily data that is not intended to be modified after the struct is created.
             Consider defining a struct instead of a class if you are trying to represent a simple set of data.



             All standard C# types (int, double, bool, char, etc.) are actually structs.

             */



            /*
             The enum keyword is used to declare an enumeration: a type that consists of a set of named constants called the enumerator list.
             By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
             For example, in the following enumeration, Sun is 0, Mon is 1, Tue is 2, and so on:


             enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; 

             You can also assign your own enumerator values:

             enum Days {Sun, Mon, Tue=4, Wed, Thu, Fri, Sat};



             In the example above, the enumeration will start from 0, then Mon is 1, Tue is 4, Wed is 5, and so on. The value of the next item in an Enum is one increment of the previous value.
             Note that the values are comma separated.
             You can refer to the values in the Enum with the dot syntax.
             In order to assign Enum values to int variables, you have to specify the type in parentheses:


                     enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
                    static void Main(string[] args)
                    {
                        int x = (int)Days.Tue;
                        Console.WriteLine(x);
                    }


             Basically, Enums define variables that represent members of a fixed set.
             Some sample Enum uses include month names, days of the week, cards in a deck, etc.

             */


            // Enums are often used with switch statements.

            TrafficLights x = TrafficLights.Red;
                switch (x) {
                    case TrafficLights.Green:
                        Console.WriteLine("Go!");
                        break;
                    case TrafficLights.Red:
                        Console.WriteLine("Stop!");
                        break;
                    case TrafficLights.Yellow:
                        Console.WriteLine("Caution!");
                        break;
                }

}

        public struct Car
        {
            public string brand;
            public double price;
        }

        enum TrafficLights { Green, Red, Yellow };



    }
}
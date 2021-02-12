using System;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             C# provides numerous built-in classes to store and manipulate data.
             One example of such a class is the Array class.
             An array is a data structure that is used to store a collection of data.
             You can think of it as a collection of variables of the same type.
             For example, consider a situation where you need to store 100 numbers.
             Rather than declare 100 different variables, you can just declare an array that stores 100 elements.

             int[] myArray;

             This statement declares an array of integers.


             Since arrays are objects, we need to instantiate them with the new keyword:

             int[] myArray = new int[5];

             This instantiates an array named myArray that holds 5 integers.


             Note the square brackets used to define the number of elements the array should hold.
             */

            // Instantiate an array of 42 elements of type double
            double[] fortyTwoDoubles = new double[42];
        }
    }
}

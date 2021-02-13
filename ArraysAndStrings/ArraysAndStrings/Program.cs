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

            /*
             After creating the array, you can assign values to individual elements by using the index number:

                int[ ] myArray = new int[5];

                myArray[0] = 23;

                This will assign the value 23 to the first element of the array.
             */

            /*
             We can provide initial values to the array when it is declared by using curly brackets:
            string[ ] names = new string[3] {"John", "Mary", "Jessica"};
            double[ ] prices = new double[4] {3.6, 9.8, 6.4, 5.9};


            We can omit the size declaration when the number of elements are provided in the curly braces:
            string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
            double[ ] prices = new double[ ] {3.6, 9.8, 6.4, 5.9};


            We can even omit the new operator. The following statements are identical to the ones above:
            string[ ] names = {"John", "Mary", "Jessica"};
            double[ ] prices = {3.6, 9.8, 6.4, 5.9};


            Array values should be provided in a comma separated list enclosed in {curly braces}.
             */

            /*
             As mentioned, each element of an array has an index number.
             int[ ] b = {11, 45, 62, 70, 88};
             0, 1, 2, 3, 4

             To access individual array elements, place the element's index number in square brackets following the array name.
             */


            /*
             It's occasionally necessary to iterate through the elements of an array, making element assignments based on certain calculations.
             This can be easily done using loops.
             For example, you can declare an array of 10 integers and assign each element an even value with the following loop:

                int[ ] a = new int[10];
                for (int k = 0; k < 10; k++) {
                  a[k] = k*2;
                }
             */

            // print all elements of an array of integers with 0 values
            int[] arr = new int[7];
            for (int k = 0; k < 7; k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
}

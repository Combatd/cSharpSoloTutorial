using System;

namespace ConditionalsAndLoops
{
    class Program
    {
        static void Main(string[] args) {

            // Fill in the blanks to display Welcome to the screen when age is greater than 16.

            //int age = 24;
            //if (age > 16) {
            //    Console.WriteLine("Welcome");
            //}

            // Fill in the blanks to find the larger of two variables.

            //int a = 42;
            //int b = 88;

            //if (a > b) {
            //    Console.WriteLine(a);
            //} else {
            //    Console.WriteLine(b);
            //}


            //int a = 8;
            //int b = ++a; // prefix on a, so a gets incremented by 1 to 9, then that value is assigned to b
            //if (a > 5)
            //    b -= 3;
            //else
            //    b = 9;
            //Console.WriteLine(b); // a meets the first condition, so it subtracts 3 from b and returns 6 

            //int x = 18;
            //switch(x) {
            //    case 10:
            //        Console.WriteLine("Ten");
            //        break;

            //    case 20:
            //        Console.WriteLine("Twenty");
            //        break;

            //    default:
            //        Console.WriteLine("No match");
            //        break;
            //}

            // Fill in the blanks to display the value of x to the screen three times.
            //int x = 42;

            //int num = 0;

            //while (num < 3) {
            //    Console.WriteLine(x);
            //    num++;
            //}

            // Fill in the blanks to increment the value of num by 2 to display only even values.
            int num = 0;
            while (num < 100) {
                Console.WriteLine(num);
                num += 2;
            }
        }
    }
}

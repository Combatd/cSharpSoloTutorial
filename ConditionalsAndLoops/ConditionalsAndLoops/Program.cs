﻿using System;

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


            int a = 8;
            int b = ++a; // prefix on a, so a gets incremented by 1 to 9, then that value is assigned to b
            if (a > 5)
                b -= 3;
            else
                b = 9;
            Console.WriteLine(b); // a meets the first condition, so it subtracts 3 from b and returns 6 

        }
    }
}

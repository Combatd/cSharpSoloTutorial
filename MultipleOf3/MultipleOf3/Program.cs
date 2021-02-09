using System;

namespace MultipleOf3
{
    /*
     * You are an elementary school teacher and explaining multiplication to students.
You     are going to use multiplication by 3 as your example.
The     program you are given takes N number as input.
        Write a program to output all numbers from 1 to N,
        replacing all numbers that are multiples of 3 by "*".
     */

    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            // your code goes here
            string output = "";

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    output += "*";
                } else
                {
                    output += i.ToString();
                }
            }

            Console.WriteLine(output);
        }
    }
}

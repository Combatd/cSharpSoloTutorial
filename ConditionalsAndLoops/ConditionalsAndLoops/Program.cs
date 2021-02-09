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
            //int num = 0;
            //while (num < 100)
            //{
            //    Console.WriteLine(num);
            //    num += 2;
            //}

            //int x = 1;
            //while (x++ < 5) { // add to iterator in condition
            //    // loop executes twice
            //    if (x % 2 == 0) {
            //        x += 2;
            //    }
            //}

            // for (initial, condition, increment)
            //for (int x = 5; x < 10; x++) {
            //    Console.WriteLine(x); // print out 5 to 9
            //}

            // Print all even values from 0 to 100
            //for (int x = 0; x < 100; x += 2) {
            //    Console.WriteLine(x);
            //}

            // init and increment can be left out if not needed, but put semicolons
            //int x = 1;
            //for (; x < 7;) {
            //    x += 2;
            //}

            // do while loops execute the code block at least once
            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x += 2;
            //} while (x < 10);

            // break stops a loop, can be put inside a conditional
            //for (int x = 1; x < 8; x++)
            //{
            //    if (x > 5)
            //        break;
            //    Console.WriteLine(x); // 5 is the largest number printed
            //}

            // continue skips the current iteration of a loop, can be put inside a conditional
            //for (int x = 0; x < 99; x++)
            //{
            //    if (x % 2 != 0) // if number is odd
            //        continue;

            //    Console.WriteLine(x);

            //}

            //int x = 5; int y = 12; // a remainder exists for the second condition
            //if (x > 10 || y / x > 1)
            //    Console.Write(y - x); // 7
            //else
            //    Console.Write(y);


            //int age = 42;
            //string msg;
            //if (age >= 18)
            //    msg = "Welcome";
            //else
            //    msg = "Sorry";

            //Console.WriteLine(msg);

            /*
             * The code above checks the value of the age variable and 
             * displays the corresponding message to the screen.
                This can be done in a more elegant and shorter way by using the ?: operator,
                which has the following form:

                Exp1 ? Exp2 : Exp3
             */

            //int age = 42;
            //string msg;
            //msg = (age >= 18) ? "Welcome" : "Sorry";
            //Console.WriteLine(msg);

            BasicCalculator();

        }

        static void BasicCalculator()
        {

            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int x = Convert.ToInt32(str);

                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);

        }

    }
}

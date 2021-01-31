using System;

namespace FirstCSharpProgram
{
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("This asks for user input!");

            //string temp;
            //temp = Console.ReadLine();

            //Console.WriteLine("variable temp value - {0}", temp);

            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You are {0} years old in 32-bit integers", age);

            //string name = Console.ReadLine();
            //string age = Console.ReadLine();
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + Convert.ToInt32(age));

            //int x = 42;
            //int y = 7;
            //int z = x * y;
            //Console.WriteLine(z);

            //int x = 16;
            //int y = 5;
            //Console.WriteLine(x / y); // 3, rounded down to int

            //int x = 4 + 3 * 2; // * has operator precedence over +
            //Console.WriteLine(x); // 10

            //int x = (4 + 3) * 2; // () has the highest operator precedence
            //Console.WriteLine(x); // 14

            //int x = (2 + 3) * 3;
            //Console.WriteLine(x); // 15

            int x = 42;
            x += 2; // equivalent to x = x + 2
            Console.WriteLine(x);

            x -= 6; // equivalent to x = x - 6
            Console.WriteLine(x);
        }
    }
}

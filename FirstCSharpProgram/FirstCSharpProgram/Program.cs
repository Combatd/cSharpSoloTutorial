using System;

namespace FirstCSharpProgram
{
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("This asks for user input!");

            //string temp;
            //temp = Console.ReadLine();

            //Console.WriteLine("variable temp value - {0}", temp);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old in 32-bit integers", age);
        }
    }
}

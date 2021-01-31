using System;

namespace FirstCSharpProgram
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("This asks for user input!");

            string temp;
            temp = Console.ReadLine();

            Console.WriteLine("variable temp value - {0}", temp);
        }
    }
}

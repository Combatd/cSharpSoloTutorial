using System;
using System.Collections.Generic;

namespace CoffeeTime
{
    /*
     A coffee shop manager is running a promotion and wants to offer a discount for coffee drinks.
    The program you are given takes the discount value as input and defines a dictionary, where the names of the coffee drinks are set as keys, and their prices are set as values.
    Write a program to discount all of the prices and output a new price list in the format shown below.
     */


    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);



        }
    }
}

using System;
using System.Collections.Generic;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackCoffee blackCoffee = new BlackCoffee();
            Latte latte = new Latte();
            Cortardo cortardo = new Cortardo();
            
            List<Coffee> coffeeList = new List<Coffee>();

            coffeeList.Add(blackCoffee);
            coffeeList.Add(latte);
            coffeeList.Add(cortardo);

            foreach (var kaffe in coffeeList)
            {
                Console.WriteLine(kaffe.ToString());
            }

        }
    }
}

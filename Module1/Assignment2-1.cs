using System;
namespace Module1
{
    internal class Assignment2_1
    {
        public void CoffeeShop()
        {
            int cost = 0;
            Console.WriteLine("Welcome to the coffee shop!");
            Console.WriteLine("What size coffee would you like? (small/medium/large)");
            String size = Console.ReadLine();
            if(size.ToLower()== "small") 
            {
                cost += 10;

            }
            else if(size.ToLower()=="medium")
            {
                cost += 15;
            }
            else if(size.ToLower()=="large")
            {
                cost += 20;
            }
            Console.WriteLine("Would you like to add milk? (yes/no)");
            String input = Console.ReadLine();
            if(input.ToLower()=="yes")
            {
                cost += 10;
            }
            Console.WriteLine("Would you like to add sugar? (yes/no)");
            String input1 = Console.ReadLine();
            if (input1.ToLower() == "yes")
            {
                cost += 5;
            }
            Console.WriteLine($"The cost of coffee is {cost}");


        }

    }
}

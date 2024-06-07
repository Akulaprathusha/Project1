using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment2_3
    {
        public void CoinTossing()
        {
            Random random = new Random();
            string[] outcomes = { "Heads", "Tails" };
            Console.WriteLine("Welcome to the Coin Toss Game!");
            bool flag = true;
            while(flag)
            {
                int Ri = random.Next(0, 2);
                Console.WriteLine($"Tossed Output is {outcomes[Ri]}");
                Console.WriteLine("Want to continue (yes/no)");
                String input = Console.ReadLine();
                if(input.ToLower()!="yes") 
                {
                    flag = false;
                }
            }
            Console.WriteLine("Thank you for playing the Coin Toss Game!");

        }
    }
}

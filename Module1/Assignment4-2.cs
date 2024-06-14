using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class TreasureChest
    {
    
            private int goldAmount;
            public TreasureChest(int initialGold)
            {
                goldAmount = initialGold;
            }
            public void AddGold(int amount)
            {
                if (amount > 0)
                {
                    goldAmount += amount;
                    Console.WriteLine($"{amount} gold added.");
                }
                else
                {
                    Console.WriteLine("Cannot add a non-positive amount of gold.");
                }
            }
            public int GetGoldAmount()
            {
                return goldAmount;
            }
            public void RemoveGold(int amount)
            {
                if (amount > 0 && amount <= goldAmount)
                {
                    goldAmount -= amount;
                    Console.WriteLine($"{amount} gold removed.");
                }
                else
                {
                    Console.WriteLine("Cannot remove the specified amount of gold.");
                }
            }
        
    }
}

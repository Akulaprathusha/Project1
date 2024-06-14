namespace Module1
{
    internal class EvenOdd
    {
        static void Main(string[] args) 
        {
            TreasureChest chest = new TreasureChest(100);
            Console.WriteLine("Initial gold amount: " + chest.GetGoldAmount());

            
            chest.AddGold(50);
            Console.WriteLine("Gold amount after adding 50: " + chest.GetGoldAmount());

            chest.RemoveGold(30);
            Console.WriteLine("Gold amount after removing 30: " + chest.GetGoldAmount());

            chest.RemoveGold(150);
            Console.WriteLine("Gold amount after attempting to remove 150: " + chest.GetGoldAmount());

            //Animal myDog = new Dog("Buddy", 3);
            //Animal myCat = new Cat("Whiskers", 2);
            //Animal myBird = new Bird("Tweety", 1);
            //myDog.MakeSound();
            //myCat.MakeSound();
            //myBird.MakeSound();


            //Console.WriteLine("Enter Student Name:");
            //string name = Console.ReadLine();

            //Assignment3_2 student = new Assignment3_2(name);

            //while (true)
            //{
            //    student.DisplayMenu();
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    student.ProcessChoice(choice, student);
            //}

            /* Console.WriteLine("Enter Account Holder Name:");
             string name = Console.ReadLine();

             Console.WriteLine("Enter Bank Account Number:");
             int accNumber = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Initial Account Balance:");
             int accBalance = Convert.ToInt32(Console.ReadLine());

             Assignment3_1 account = new Assignment3_1(name, accNumber, accBalance);

             bool exit = false;
             while (!exit)
             {
                 Console.WriteLine("\nChoose an option:");
                 Console.WriteLine("1. Check Balance");
                 Console.WriteLine("2. Deposit Amount");
                 Console.WriteLine("3. Withdraw Amount");
                 Console.WriteLine("4. Exit");
                 int choice = Convert.ToInt32(Console.ReadLine());

                 switch (choice)
                 {
                     case 1:
                         account.CheckBalance(account);
                         break;
                     case 2:
                         account.DepositAmount(account);
                         break;
                     case 3:
                         account.WithDrawAmount(account);
                         break;
                     case 4:
                         exit = true;
                         break;
                     default:
                         Console.WriteLine("Invalid choice, please try again.");
                         break;
                 }
             }
            */

            //Assignment2_4 ae = new Assignment2_4();
            //ae.MovieRecomendationSystem();

            // Assignment2_3 ae = new Assignment2_3();
            //ae.CoinTossing();
            //Console.WriteLine("Enter a Number"); // For printing in console
            //int number = Convert.ToInt32(Console.ReadLine()); // reading from console and converting string to integer
            //if (number % 2 == 0) // logic for even
            //{
            //    Console.WriteLine($"The given number {number} is even");
            //}
            //else 
            //{
            //    Console.WriteLine($"The given number {number} is odd");
            //}
            // Assignment1_2 ae = new Assignment1_2();
            //ae.Game();

            // Assignment2_1 ae = new Assignment2_1 ();
            //ae.CoffeeShop();

            //Assignment2_2 ae = new Assignment2_2();
            //ae.GuessingGame();



        }
    }
}

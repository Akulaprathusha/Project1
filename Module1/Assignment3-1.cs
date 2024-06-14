using System;
namespace Module1
{
    internal class Assignment3_1
    {
        private String AccHolderName;
        private int BankAccNumber;
        private int AccBalance;
       public  Assignment3_1(String AccHolderName, int BankAccNumber, int AccBalance)
        {
            this.AccHolderName = AccHolderName;
            this.BankAccNumber = BankAccNumber;
            this.AccBalance = AccBalance;
        }

        public void CheckBalance(Assignment3_1 ae)
        {
            Console.WriteLine($"The Current Balance in Account Number {BankAccNumber} is {AccBalance}");
        }

        public void DepositAmount(Assignment3_1 ae)
        {
            Console.WriteLine("Enter the amount to be deposited");
            int DepositAmt = Convert.ToInt32(Console.ReadLine());
            ae.AccBalance += DepositAmt;
            Console.WriteLine($"The Current balance in Account Number {BankAccNumber} is {AccBalance}");
        }

        public void WithDrawAmount(Assignment3_1 ae)
        {
            Console.WriteLine("Enter the amount to be Withdrawn");
            int WithDrawAmt = Convert.ToInt32(Console.ReadLine());
            if(ae.AccBalance >= WithDrawAmt)
            {
                ae.AccBalance -= WithDrawAmt;
                Console.WriteLine($"The Current balance in Account Number {BankAccNumber} is {AccBalance}");
            }
            else
            {
                Console.WriteLine("Insuffient Balance");
                Console.WriteLine($"The Current balance in Account Number {BankAccNumber} is {AccBalance}");
                //Console.WriteLine("If You want to try to withdrawn again? (yes/no)");
                //String choice = Console.ReadLine();
                //if ((choice.ToLower()=="yes"))
                //    Console.WriteLine("Enter the amount to be Withdrawn");
                //int WithDrawAmt1 = Convert.ToInt32(Console.ReadLine());
                //if (ae.AccBalance >= WithDrawAmt1)
                //{
                //    ae.AccBalance -= WithDrawAmt1;
                //    Console.WriteLine($"The Current balance in Account Number {BankAccNumber} is {AccBalance}");
                //}
            }
            
            
        }

    }
}

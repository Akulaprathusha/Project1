using System;

namespace deligate
{
    internal class Program
    {
        public delegate void AddDelegate(int FirstNumber , int SecondNumber);
        public delegate void Add3Delegate(int FirstNumber, int SecondNumber, int ThirdNumber);
        static void Main(string[] args)
        {
            AddDelegate delegate1 = new AddDelegate(Add);
            delegate1(10, 20);
            Program program = new Program();
            Add3Delegate delegate2 = new Add3Delegate(program.Add);
            delegate2(10, 20, 30);

        }

        static void Add(int n1, int n2)
        {
            Console.WriteLine("{0}", (n1+n2) );
        }

         void Add(int n1,int n2,int n3)
        {
            Console.WriteLine("{0}", (n1 + n2 + n3));

        }
    }
}

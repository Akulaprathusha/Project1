using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment1_3
    {
        public void CalculateRectangleArea()
        {
            Console.WriteLine("Enter Length of reactangle");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            int Area = Length * Breadth;
            Console.WriteLine($"The Area of Recatangle of Length {Length} and Breadth {Breadth} is  {Area}");

        }
        public void CalculateCylinderVolume()
        {
            double pi = 3.14;
            Console.WriteLine("Enter height of Cylinder");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter radius of Cylinder");
            int Radius = Convert.ToInt32(Console.ReadLine());
            double Volume = pi * (Radius * Radius) * Height;
            Console.WriteLine($"The Volume of Cylinder of Height {Height} and radius {Radius} is  {Volume}");

        }

        public void ConditionalOperators()

        {
            Console.WriteLine("Conditional Operators");
            Console.WriteLine("Enter a First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("FirstNumber is equal to Second Number");
            }
            else if (SecondNumber < FirstNumber)
            {
                Console.WriteLine("First Number is greater than Second Number");
            }
            else if (SecondNumber > FirstNumber)
            {
                Console.WriteLine("First Number is lesser than Second Number");
            }
        }

        public void LogicalOperators()
        {
            Console.WriteLine("Logical Operators");
            Console.WriteLine("Enter a Number");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input >= 1 && input <= 100)
            {
                Console.WriteLine($"The number {input} is in the range of 1 to 100");
            }
            else
            {
                Console.WriteLine($"The number {input} is out of  the range of 1 to 100");
            }
        }

        public void BitwiseOperators()
        {
            Console.WriteLine("Bitwise Operators");
            Console.WriteLine("Enter a First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            int resultAND = FirstNumber & SecondNumber;
            int resultOR = FirstNumber | SecondNumber;
            Console.WriteLine($" The Bitwise And of two operands are {resultAND}");
            Console.WriteLine($" The Bitwise OR of two operands are {resultOR}");
        }
    }
}

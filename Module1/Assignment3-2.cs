using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment3_2
    {
        private string StudentName;
        private List<int> Grades;

        public Assignment3_2(string StudentName)
        {
            this.StudentName = StudentName;
            this.Grades = new List<int>();
        }

        public void AddGrade(Assignment3_2 student)
        {
            int grade = InputGrade("Enter the grade to be added:");
            student.Grades.Add(grade);
            Console.WriteLine($"Grade {grade} has been added for {student.StudentName}.");
        }

        public void CalculateAverage(Assignment3_2 student)
        {
            if (student.Grades.Count == 0)
            {
                Console.WriteLine("No grades available to calculate average.");
                return;
            }

            double average = 0;
            foreach (int grade in student.Grades)
            {
                average += grade;
            }
            average /= student.Grades.Count;
            Console.WriteLine($"The average grade for {student.StudentName} is {average:F2}.");
        }

        public void DisplayStudentInfo(Assignment3_2 student)
        {
            Console.WriteLine($"Student Name: {student.StudentName}");
            Console.WriteLine("Grades: " + string.Join(", ", student.Grades));
            CalculateAverage(student);
        }

        public  int InputGrade(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        public  void DisplayMenu()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Grade");
            Console.WriteLine("2. Calculate Average");
            Console.WriteLine("3. Display Student Info");
            Console.WriteLine("4. Exit");
        }

        public  void ProcessChoice(int choice, Assignment3_2 student)
        {
            switch (choice)
            {
                case 1:
                    student.AddGrade(student);
                    break;
                case 2:
                    student.CalculateAverage(student);
                    break;
                case 3:
                    student.DisplayStudentInfo(student);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
}

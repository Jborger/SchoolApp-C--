using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System - V1");
            Console.WriteLine("MetalPhoenix Systems");
            Console.WriteLine("Please enter the number of Students:");
            var studentCount = int.Parse(Console.ReadLine());
            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                studentNames[i] = Console.ReadLine();
                Console.Write("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: {0}, Grade {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
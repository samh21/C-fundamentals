using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)

        {
            var book = new Book("Sam's Book");
            book.AddGrade(89.1);
            book.AddGrade(83.7);
            book.AddGrade(81.4);
            var stats = book.GetStatistics();
            System.Console.WriteLine($"Your highest grade is {stats.High}");
            System.Console.WriteLine($"Your lowest grade is {stats.Low}");
            System.Console.WriteLine($"`your average grade is {stats.Average:N1}");

        }
    }
}

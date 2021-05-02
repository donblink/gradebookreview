using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(98.7);
            book.AddGrade(96.2);
            book.AddGrade(67.2);
            book.AddGrade(55.3);
            book.AddGrade(66.3);
            
            double average = book.calculateAverage();

            Console.WriteLine($"you current average score is : {average:N1}");



        }

       
    }
}

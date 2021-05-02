using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.addGrade(98.7);
            book.addGrade(96.2);
            book.addGrade(67.2);
            book.addGrade(55.3);
            book.addGrade(66.3);
            
            double average = book.calculateAverage();

            Console.WriteLine($"you current average score is : {average:N1}");



        }

       
    }
}

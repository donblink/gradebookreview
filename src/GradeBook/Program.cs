using System;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            
            book.AddGrade(99.1);
            book.AddGrade(75.8);
            book.AddGrade(65.2);


            
            Statistic statistic = book.GetStatistics();
            statistic.PrintSummary();

        }


    }
}

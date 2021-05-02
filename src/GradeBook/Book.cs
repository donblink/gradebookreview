using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        private double average;
        private List <double> grades;
        public Book()
        {
           grades = new List<double>();
           average = 0;   
        }

        public void AddGrade(double grade )
        {
            grades.Add(grade);
    
        }

        public Statistic GetStatistics()
        {
            Statistic statistic = new Statistic();
            statistic.Average = statistic.CalculateAverage(grades);
            statistic.Highest = statistic.FindHighestGrade(grades);
            statistic.Lowest  = statistic.FindLowestGrade(grades);
            return statistic;
        }
      
    }
}
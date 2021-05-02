using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistic
    {
        public Statistic()
        {
            Average = 0;
            Lowest  = 0; 
            Highest = 0;

        }

          public  double CalculateAverage( List <double> grades )
        {
            double total = 0;
            foreach (double grade in grades)
            {
                total = total + grade;
            }

            return Average = total / grades.Count;
            
            
        }

        public double FindHighestGrade(List <double> grades )
        {
            Highest = double.MinValue;
            foreach (var grade in grades)
            {
                if( grade >= Highest)
                {
                    Highest = grade;
                }
                
            }
            return Highest;
            
        }

        public  double FindLowestGrade(List <double> grades )
        {
            Lowest = double.MaxValue;
            foreach (var grade in grades)
            {
                if( grade <= Lowest)
                {
                    Lowest = grade;
                }
                
            }
            return Lowest;
            
        }

        public void PrintSummary()
        {
            Console.WriteLine($"your lowest grade is {this.Lowest} ");
            Console.WriteLine($"your highest grade is {this.Highest} ");
            Console.WriteLine($"the average of the all the grade are {this.Average}");
        }

        internal double Average;
        internal double Lowest;
        internal double Highest;
    }
    
}
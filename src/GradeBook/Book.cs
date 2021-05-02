using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private double _average;
        private List <double> _gradeList;
        public Book()
        {
           _gradeList = new List<double>();
           _average = 0;   
        }

        public void addGrade(double grade )
        {
            _gradeList.Add(grade);
    
        }
        public double calculateAverage()
        {
            double total = 0;
            foreach (double grade in _gradeList)
            {
                total = total + grade;
            }

            double average = total / _gradeList.Count;
            _average = average;
            return _average;
        }
    }
}
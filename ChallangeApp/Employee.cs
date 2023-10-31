﻿

using homeWork;
using System.Diagnostics;
using System.Threading.Tasks.Sources;

namespace HomeWork
{
    public class Employee
    {
        List<float> Grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public float GetPoints { get {
                return Grades.Sum();
            } }
        public Employee(string name, string surname, int age) 
        { 
            this.Name = name;
            this.Surname = surname;  
            this.Age = age;
               
        }
        public Employee()
        {
            this.Name = "None";
            this.Surname = "None";
            this.Age = 0;
           
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
            else
                Console.WriteLine("Invalid data");
           
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out var points))
            {
                this.AddGrade(points);
            }
            else
                Console.WriteLine("Value is not float");
        }
        public void AddGrade(double grade)
        {
           AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            AddGrade((float)grade);

        }

        public void SubScore(uint points)
        {
            int change = 0 - (int)points;
            this.Grades.Add(change);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
          
            foreach (var grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade ;
                               
            }
            statistics.Average /= this.Grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int idx = 0;

            while(idx < this.Grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[idx]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[idx]);
                statistics.Average += this.Grades[idx];
                idx++;
            }

            statistics.Average /= this.Grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int idx = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[idx]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[idx]);
                statistics.Average += this.Grades[idx];

            } while(++idx < this.Grades.Count);

            statistics.Average /= this.Grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for(int idx = 0;  idx < this.Grades.Count; idx++)
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[idx]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[idx]);
                statistics.Average += this.Grades[idx];
            }
            statistics.Average /= this.Grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average /= this.Grades.Count;

            return statistics;

            
        }

    }
}

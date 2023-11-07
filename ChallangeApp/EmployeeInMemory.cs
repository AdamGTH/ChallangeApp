﻿
using homeWork;

namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        List<float> Grades = new List<float>();
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
            else
                throw new Exception("Invalid data");
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out var points))
            {
                this.AddGrade(points);
            }
            else
                throw new Exception("Value is not float");
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public override void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;

                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;

                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;

                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;

                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;

                default:
                    throw new Exception("Wrong letter");

            }
        }
        public override Statistics GetStatistics()
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

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;

                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;

                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;

                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;

                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

    }
}



using homeWork;
using System.Collections;
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
                throw new Exception("Invalid data");
                
           
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out var points))
            {
                this.AddGrade(points);
            }
            else
                throw new Exception("Value is not float");
            
        }
        public void AddGrade(double grade)
        {
           AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            AddGrade((float)grade);

        }
        public void AddGrade(char grade)
        {
           switch(grade)
            {
                case 'A':
                case 'a':
                    this.Grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.Grades.Add(80);
                    break;

                case 'C':
                case 'c':
                    this.Grades.Add(60);
                    break;

                case 'D':
                case 'd':
                    this.Grades.Add(40); 
                    break;

                case 'E':
                case 'e':
                    this.Grades.Add(20);
                    break;

                default:
                    throw new Exception("Wrong letter");
                    
            }
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

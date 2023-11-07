
using homeWork;
using System.Runtime.CompilerServices;

namespace ChallangeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        private const string fileName = "grades.txt";
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
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
            List<float> grades = new List<float>();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var lines = reader.ReadLine();
                    while (lines != null)
                    {
                        grades.Add(float.Parse(lines));
                        lines = reader.ReadLine();
                    }
                }

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= grades.Count;

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

            }
           
            return statistics;
        }

    }
}

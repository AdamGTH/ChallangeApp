
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

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
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
                    statistics.AddGrade(grade);
                }
            }
                return statistics;
        }

    }
}

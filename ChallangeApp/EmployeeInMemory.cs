
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

        public override event GradeAddedDelegate GradeAdded;
        
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
               
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
            
            foreach(var grade in this.Grades)
            {
             statistics.AddGrade(grade);
            }
            
            return statistics;
        }

    }
}

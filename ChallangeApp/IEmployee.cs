
using homeWork;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get;}
        string Surname { get;}
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        void SubScore(uint points);
        Statistics GetStatistics();

    }
}

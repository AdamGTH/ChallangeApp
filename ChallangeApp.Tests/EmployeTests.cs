using homeWork;
using HomeWork;
using System.Runtime.InteropServices;

namespace homeWorkChallange.Tests
{
    public class Tests
    {
       [Test]
        public void TestMethodAddScoreAndSubScoreForEmployee()
        {
            //arrange
            Employee Worker1 = new Employee("Adam", "Nowak", 23);

            //act
            Worker1.AddGrade(10);
            Worker1.AddGrade(20);
            Worker1.SubScore(50);
            float res = Worker1.GetPoints;

            //assert
            Assert.AreEqual(-20, res);
            
        }

        [Test]
        public void TestMaxValueFromMethodGetStatistics()
        {
            //arrange
            Employee Worker1 = new Employee();
            Statistics statistics = new Statistics();

            //act
            Worker1.AddGrade(10.33f);
            Worker1.AddGrade(20.33f);
            Worker1.AddGrade(50.33f);
            statistics = Worker1.GetStatistics();

            //assert
            Assert.AreEqual(50.33f, statistics.Max);

        }

        [Test]
        public void TestMinValueFromMethodGetStatistics()
        {
            //arrange
            Employee Worker1 = new Employee();
            Statistics statistics = new Statistics();

            //act
            Worker1.AddGrade(10.33f);
            Worker1.AddGrade(20.33f);
            Worker1.AddGrade(50.33f);
            statistics = Worker1.GetStatistics();

            //assert
            Assert.AreEqual(10.33f, statistics.Min);

        }

        [Test]
        public void TestAverageValueFromMethodGetStatistics()
        {
            //arrange
            Employee Worker1 = new Employee();
            Statistics statistics = new Statistics();

            //act
            Worker1.AddGrade(5);
            Worker1.AddGrade(3);
            Worker1.AddGrade(2);
            statistics = Worker1.GetStatistics();
            
            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));

        }
        [Test]
        public void TestAverageLetterValueFromMethodGetStatistics()
        {
            //arrange
            Employee Worker1 = new Employee();
            Statistics statistics = new Statistics();

            //act
            Worker1.AddGrade('a');
            Worker1.AddGrade('A');
            Worker1.AddGrade('b');
            Worker1.AddGrade('C');
            Worker1.AddGrade('d');
            Worker1.AddGrade('e');
            Worker1.AddGrade("44");
            Worker1.AddGrade("435");
            Worker1.AddGrade("ee");
            Worker1.AddGrade(1000);
            Worker1.AddGrade('x');
            Worker1.AddGrade('z');
            statistics = Worker1.GetStatistics();

            //assert
            Assert.AreEqual('B', statistics.AverageLetter);

        }
    }
}
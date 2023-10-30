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
            Worker1.AddScore(10);
            Worker1.AddScore(20);
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
            Worker1.AddScore(10.33f);
            Worker1.AddScore(20.33f);
            Worker1.AddScore(50.33f);
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
            Worker1.AddScore(10.33f);
            Worker1.AddScore(20.33f);
            Worker1.AddScore(50.33f);
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
            Worker1.AddScore(5);
            Worker1.AddScore(3);
            Worker1.AddScore(2);
            statistics = Worker1.GetStatistics();
            
            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));

        }
    }
}
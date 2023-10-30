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
            Worker1.AddScore(10.1f);
            Worker1.AddScore(20.2f);
            Worker1.AddScore(50.3f);
            statistics = Worker1.GetStatistics();
            
            //assert
            Assert.AreEqual(26.866667f, statistics.Average);

        }
    }
}
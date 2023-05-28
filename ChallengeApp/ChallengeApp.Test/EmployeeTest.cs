namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectAverages()
        {
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round (5.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }

        public void GetStatisticsShouldReturnCorrectLetterMin()
        {
            var employee = new Employee();

            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectLetterMax()
        {
            var employee = new Employee();

            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectLetterAverage()
        {
            var employee = new Employee();

            employee.AddGrade(34);
            employee.AddGrade(12);
            employee.AddGrade(8);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}



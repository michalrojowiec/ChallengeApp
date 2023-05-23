namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void TestingAverageGrades()
        {
            var employee = new Employee("Michał", "Kowalik");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round (5.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void TestingMaximumGrades()
        {
            var employee = new Employee("Michał", "Kowalik");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void TestingMinimumGrades()
        {
            var employee = new Employee("Michał", "Kowalik");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }
    }
}



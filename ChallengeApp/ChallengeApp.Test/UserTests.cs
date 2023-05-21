using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void EmployeeScoreTests_AreResultsCorrect()
        {
            var user = new Employee("Micha³", "Kowalik", "32");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);
            user.AddScore(-4);

            var result = user.Result;

            Assert.AreEqual(9, result);      
        }
    }
}
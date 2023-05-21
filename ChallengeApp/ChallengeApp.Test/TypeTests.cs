using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void TestingIntigers()
        { 
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestingDifferentEmployees()
        {
            var user1 = GetUser("Michał");
            var user2 = GetUser("Wojtek");


            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void TestingFloats()
        {
            float number1 = 15022;
            float number2 = 15022;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestingStrings()
        {
            string name1 = "Michał";
            string name2 = "Michał";

            Assert.AreEqual(name1, name2);
        }



        private Employee GetUser(string name)
        {
            return new Employee("name", "surname", "age");
        }
    }
}



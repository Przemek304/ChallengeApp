
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        // Tpyp wartościowe

        [Test]
        public void AreEqualShouldReturnEqualNumbers1()
        {

            //  arrange
            double number1 = 222227843222222;
            double number2 = 44432422422222;


            //  act

            //  assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void AreEqualShouldReturnEqualNumbers2()
        {

            //  arrange
            float number1 = 2222297843222222;
            float number2 = 222322222422422222;


            //  act

            //  assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void AreEqualShouldReturnEqualNumbers3()
        {

            //  arrange
            int number1 = 5;
            int number2 = 5;


            //  act

            //  assert
            Assert.AreEqual(number1, number2);
        }


        // Typy referencyjne

        [Test]
        public void GetUserShouldreturnDiffrentObjects()
        {

            //  arrange
            var user1 = GetUser("worker");
            var user2 = GetUser("worker");
            
            //  act

            //  assert
            Assert.AreNotEqual(user1, user2);
        }
     
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}

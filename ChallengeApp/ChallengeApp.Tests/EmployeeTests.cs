using NUnit.Framework;

namespace ChallengeApp.Tests
{

    public class EmployeeTests
    {
        private Statistics statistisc;
        [Test]
        public void WhenEmployeeCollectCorrectGrade_ThenCorrectGrade()
        {
             
            //  arrange
            Employee employee = new Employee("Adam" , "Kowalski" );
            employee.AddGrades(4);
            employee.AddGrades(8);
            employee.AddGrades(6);


            //  act
            var statistisc = employee.GetStatistics();

            //  assert
            Assert.AreEqual(6f,statistisc.Average);
        } 

        [Test]
        public void WhenEmployee2CollectCorrectGrade_ThenCorrectGrade()
        {

            //  arrange
           Employee employee = new Employee("Adam" , "Kowalski");
            employee.AddGrades(4);
            employee.AddGrades(8);
            employee.AddGrades(6);
            //  act
            var statistisc = employee.GetStatistics();

            
            //  assert
            Assert.AreEqual(4 , statistisc.Min);
        }

        [Test]
        public void WhenEmployee3CollectCorrectGrade_ThenCorrectGrade()
        {

            //  arrange
            Employee employee = new Employee("Adam", "Kowalski");
            employee.AddGrades(4);
            employee.AddGrades(8);
            employee.AddGrades(6);
            //  act
            var statistisc = employee.GetStatistics();


            //  assert
            Assert.AreEqual(8, statistisc.Max);
        }


    }
}

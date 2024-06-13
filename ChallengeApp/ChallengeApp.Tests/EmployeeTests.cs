using NUnit.Framework;

namespace ChallengeApp.Tests
{

    public class EmployeeTests
    {
        private Statistisc statistisc;
        [Test]
        public void cos1()
        {
             
            //  arrange
            Employee employee = new Employee("Robert" , "Kowalski" );
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(1);


            //  act
            var statistisc = employee.GetStatistisc();

            //  assert
            Assert.AreEqual(5,statistisc.Average);
        } d

        [Test]
        public void cos2()
        {

            //  arrange
           Employee employee = new Employee("Michał" , "Las");
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(5);
            //  act
            var statistisc = employee.GetStatistisc();

            S
            //  assert
            Assert.AreNotEqual(5 , statistisc.Min);
        }

        [Test]
        public void cos3()
        {

            //  arrange
            Employee employee = new Employee("Kamil", "Nowak");
            employee.AddGrade(-6);
            employee.AddGrade(3);
            employee.AddGrade(-5);
            //  act
            var statistisc = employee.GetStatistisc();


            //  assert
            Assert.AreNotEqual(6, statistisc.Max);
        }


    }
}

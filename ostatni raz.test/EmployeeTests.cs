
using System.Diagnostics;

namespace ostatni_raz.test
{
    public class EmployeeTests
    {
        private Statistics statistics;

        [Test]
        public void WhenGetAverageValueEmployee()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            // act
            statistics = new Statistics();
            // assert
            Assert.AreEqual(3, statistics.Average);

        }
        [Test]
        public void WhenGetMinValueEmployee()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            // act
            statistics = new Statistics();
            // assert
            Assert.AreEqual(2, statistics.Min);

        }
        [Test]
        public void WhenGetMaxValueEmployee()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            // act
            statistics = new Statistics();
            // assert
            Assert.AreEqual(6, statistics.Max);

        }
    }
}
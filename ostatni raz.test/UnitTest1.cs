namespace ostatni_raz.test
{
    public class EmployeeTests
    {


        [Test]
        public void WhenEmployeeCollectAddPositivePoints_ShouldCorrectResult()
        {
            // arrange
            var employee1= new Employee("Adam","Nowak",18);

            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(2);
            // act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenEmployeeCollectAddNegativePoints_ShouldCorrectResult()
        {
            // arrange
            var employee2 = new Employee("Marysia", "Kwiatkowska", 49);

            employee2.AddScore(-1);
            employee2.AddScore(-6);
            employee2.AddScore(-2);

            // act
            var result = employee2.Result;

            // assert
            Assert.AreEqual(-9, result);
        }

        [Test]
        public void WhenEmployeeCollectAddMixedPoints_ShouldCorrectResult()
        {
            // arrange
            var employee3 = new Employee("Dorota", "Kowalska", 24);

            employee3.AddScore(-5);
            employee3.AddScore(6);
            employee3.AddScore(-2);

            // act
            var result = employee3.Result;

            // assert
            Assert.AreEqual(-1, result);
        }
    }
}
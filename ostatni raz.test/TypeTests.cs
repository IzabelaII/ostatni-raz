
using System.Xml.Linq;

namespace ostatni_raz.test
{
    public class TypeTests
    {
        [Test]
        public void GetNumberReturnDefferentObjects()
        {
            // arrange
           int number1 = 1;
           int number2 = 2;

            // act


            // assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void GetUserReturnDefferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam","a");
            var user2 = GetUser("Adam","a");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);

        }
        private User GetUser(string name, string password) 
        {
            return new User(name,password);
        }


    }
   
        
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        public RegexUserValidation user;

        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            user = new RegexUserValidation();
        }
        [TestMethod]
        public void UserFistNameValidationReturnTrue()
        {
            string firstName = "Akshay";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void UserLastNameValidationReturnTrue()
        {
            string lastName = "Kumar";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailIdValidationReturnTrue()
        {
            string email = "Akshay396@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationReturnTrue()
        {
            string mobileNumber = "91 9173926478";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationReturnTrue()
        {
            //Arrange

            string password = "Kumar$123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void UserFistNameValidationReturnFalse()
        {
            string firstName = "akshay";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UserLastNameValidationReturnFalse()
        {
            string lastName = "kumar";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmailIdValidationReturnFalse()
        {
            string email = "Akshay.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void MobileNumberValidationReturnFalse()
        {
            string mobileNumber = "91 0123456789";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void PasswordValidationReturnFalse()
        {
            string password = "akshay@123*";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}

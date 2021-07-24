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

        [TestMethod]
        public void UserFistNameValidationReturnCustomInvalidFirstNameException()
        {
            try
            {
                string firstName = "akshay";
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastNameValidationReturnCustomInvalidLastNameException()
        {
            try
            {
                string lastName = "kumar";
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailIdValidationReturnCustomInvalidEmailException()
        {
            try
            {
                string email = "Akshay.com";
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }
        [TestMethod]
        public void MobileNumberValidationReturnCustomInvalidMobileException()
        {
            try
            {
                string mobileNumber = "91 0123456789";
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
        [TestMethod]
        public void PasswordValidationReturnCustomInvalidPasswordException()
        {
            try
            {
                string password = "akshay@123*";
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }

        // Parameterised Test to validate multiple entry for the Email Address..........
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
    }
}

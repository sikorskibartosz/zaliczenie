//using NUnit.Framework;
//using Pesel;
//using System.IO;

//namespace PeselTests
//{
//    public class ProgramTests
//    {
//        [Test]
//        public void IsPeselValid_ValidPesel_ReturnsTrue()
//        {
//            // Arrange
//            string pesel = "44051401458";

//            // Act
//            bool result = Program.IsPeselValid(pesel);

//            // Assert
//            Assert.IsTrue(result);
//        }

//        [Test]
//        public void IsPeselValid_InvalidPesel_ReturnsFalse()
//        {
//            // Arrange
//            string pesel = "12345678901";

//            // Act
//            bool result = Program.IsPeselValid(pesel);

//            // Assert
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void IsPeselValid_PeselTooShort_ReturnsFalse()
//        {
//            // Arrange
//            string pesel = "1234567890";

//            // Act
//            bool result = Program.IsPeselValid(pesel);

//            // Assert
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void IsPeselValid_PeselTooLong_ReturnsFalse()
//        {
//            // Arrange
//            string pesel = "123456789012";

//            // Act
//            bool result = Program.IsPeselValid(pesel);

//            // Assert
//            Assert.IsFalse(result);
//        }
//    }

//    public class ResidentTests
//    {
//        [Test]
//        public void ToString_CorrectlyFormatsResidentInformation()
//        {
//            // Arrange
//            Resident resident = new Resident("City", "Name", "Surname", "Pesel");

//            // Act
//            string result = resident.ToString();

//            // Assert
//            Assert.AreEqual("City, Name Surname, Pesel", result);
//        }
//    }
//}
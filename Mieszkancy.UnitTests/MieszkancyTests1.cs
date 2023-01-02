using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using Pesel;

namespace Mieszkancy.UnitTests1
{
    public class MieszkancyTests
    {
        [Test]
        public void ToString_CorrectlyFormatsResidentInformation()
        {
            // Arrange
            MieszkancyTests resident = new Pesel.Mieszkancy("City", "Name", "Surname", "Pesel");

            // Act
            string result = resident.ToString();

            // Assert
            Assert.AreEqual("City, Name Surname, Pesel", result);
        }
    }
}

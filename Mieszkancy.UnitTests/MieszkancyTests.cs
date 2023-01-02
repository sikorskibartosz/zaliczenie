using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using Pesel;

namespace Mieszkancy.UnitTests
{
    class MieszkancyTests
    {
        [Test]
        public void IsPeselValid_ValidPesel_ReturnsTrue()
        {
            // Arrange
            string pesel = "44051401458";

            // Act
            bool result = Program.IsPeselValid(pesel);

            // Assert
            Assert.IsTrue(result);
        }
    }
}

using MutantDemo;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace IsoscelesTest
{
    [TestFixture]
    public class IsoscelesTest
    {
        [Test]
        public void IsoscelesTriangle_InputTwoSideEqual_OutputIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 4;
            int secondSide = 4;
            int thirdSide = 8;

            string expected = "The triangle is isosceles.";

            //Act
            string actual = Triangle.IsoscelesTriangle(firstSide, secondSide, thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
                
        [Test]
        public void IsoscelesTriangle_InputThreeSideUnEqual_OutputNotIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 6;

            string expected = "The triangle is isosceles.";

            //Act
            string actual = Triangle.IsoscelesTriangle(firstSide, secondSide, thirdSide);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}

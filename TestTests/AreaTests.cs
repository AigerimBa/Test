using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void CircleTest()
        {
            var area = new Area();
            double a =1;

            // Act
            try
            {
                area.Circle(a);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Ожидаемое исключение не было сгенерировано.");
                return;
            }
        }

        [TestMethod]
        public void TriangleTest()
        {
            var area = new Area();
            double a = 1;
            double b = 1;
            double c = 1;

            // Act
            try
            {
                area.Triangle(a, b, c);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Ожидаемое исключение не было сгенерировано.");
                return;
            }
        }
    }
}
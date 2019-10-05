using NUnit.Framework;
using SquaresOfFigures;

namespace SquaresTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void TriangleSquareTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int expected = 6;
            Squares figure = new Squares();
            Assert.AreEqual(expected, figure.TriangleSquare(a, b, c));

        }

        [Test]
        public void RoundSquareTest()
        {
            int radius = 3;
            double expected = 28.27;
            Squares figure = new Squares();
            Assert.AreEqual(expected, figure.RoundSquare(radius));

        }
    }
}
using Xunit;
using MyRootLib;

namespace MyRootLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSquareRootOf4()
        {
            double a = 4; // arrange
            double expected = 2; // expected result

            double actual = Class1.MyRoot(a); // act, use Class1 instead of Root

            Assert.Equal(expected, actual); // assert
        }

        [Fact]
        public void TestSquareRootOf9()
        {
            double a = 9; // arrange
            double expected = 3; // expected result

            double actual = Class1.MyRoot(a); // act, use Class1 instead of Root

            Assert.Equal(expected, actual); // assert
        }
    }
}

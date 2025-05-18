using Xunit;
using PrimeFactorLib;

namespace PrimeFactorTests
{
    public class PrimeCalculatorTests
    {
        [Theory]
        [InlineData(4, "2 x 2")]
        [InlineData(7, "7")]
        [InlineData(30, "2 x 3 x 5")]
        [InlineData(40, "2 x 2 x 2 x 5")]
        [InlineData(50, "2 x 5 x 5")]
        public void PrimeFactors_ReturnsCorrectFactors(int input, string expected)
        {
            var result = PrimeCalculator.PrimeFactors(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrimeFactors_ThrowsException_ForInvalidInput()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => PrimeCalculator.PrimeFactors(1));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => PrimeCalculator.PrimeFactors(1001));
        }
    }
}

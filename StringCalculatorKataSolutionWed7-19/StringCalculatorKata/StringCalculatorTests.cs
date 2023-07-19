
namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            // Given
            var calculator = new StringCalculator();

            // When
            var result = calculator.Add("");

            // Assert
            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("1",1)]
        [InlineData("2", 2)]
        [InlineData("108", 108)]
        public void SingleDigit(String numbers, int expected)
        {
            // Given
            var calculator = new StringCalculator();

            // When
            var result = calculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("1,3", 4)]
        [InlineData("0,1", 1)]
        public void TwoDigits(String numbers, int expected)
        {
            // Given
            var calculator = new StringCalculator();

            // When
            var result = calculator.Add(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

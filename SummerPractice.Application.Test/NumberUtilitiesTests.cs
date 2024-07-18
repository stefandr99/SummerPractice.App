namespace SummerPractice.Application.Test
{
    using FluentAssertions;

    public class NumberUtilitiesTests
    {
        private readonly NumberUtilities _numberUtilities = new();

        [Fact]
        public void Should_CalculateCorrectAverage_When_NumbersAreAllIntegers()
        {
            // Arrange
            var numbers = "1,2,3";

            // Act
            var result = this._numberUtilities.CalculateAverage(numbers);

            // Assert
            result.Should().Be(2);
        }

        [Fact]
        public void Should_ThrowException_When_EmptyStringIsPassed()
        {
            // Arrange
            var numbers = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._numberUtilities.CalculateAverage(numbers));
        }
    }
}
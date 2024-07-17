namespace SummerPractice.Application.Tests
{
    using FluentAssertions;

    public class NumberUtilitiesTests
    {
        private readonly NumberUtilities _numberUtilities = new();

        [Fact]
        public void Should_CalculateAverage_When_ValidCommaSeparatedStringIsPassed()
        {
            // Arrange
            var numbers = "1,2,3,4,5";

            // Act
            var result = this._numberUtilities.CalculateAverage(numbers);

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_CalculateAverage_When_StringWithExtraSpacesIsPassed()
        {
            // Arrange
            var numbers = " 1, 2 , 3 , 4, 5 ";

            // Act
            var result = this._numberUtilities.CalculateAverage(numbers);

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_ThrowException_When_EmptyStringIsPassed()
        {
            // Arrange
            var numbers = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._numberUtilities.CalculateAverage(numbers));
        }

        [Fact]
        public void Should_CalculateAverageAndIgnoreInvalidIntegers_When_StringContainsBothValidAndInvalidData()
        {
            // Arrange
            var numbers = "1, 2, three, 4, 5";

            // Act
            var result = this._numberUtilities.CalculateAverage(numbers);

            // Assert
            result.Should().Be(3);
        }

        [Fact]
        public void Should_ThrowException_When_NoValidIntegersFound()
        {
            // Arrange
            var numbers = "one, two, three";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._numberUtilities.CalculateAverage(numbers));
        }

        [Fact]
        public void Should_CalculateAverage_When_NumbersAreNegative()
        {
            // Arrange
            var numbers = "-1, -2, -3";

            // Act
            var result = this._numberUtilities.CalculateAverage(numbers);

            // Assert
            result.Should().Be(-2);
        }
    }
}
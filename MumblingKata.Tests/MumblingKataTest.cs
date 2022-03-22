using Xunit;

namespace MumblingKata.Tests
{
    public class MumblingKataTest
    {
        private readonly MumblingKata _mumbling = new MumblingKata();
        [Fact]
        public void Mumble_Letters_ShouldReturnA_WhenGivena()
        {
            //Act
            var result = _mumbling.Mumble_Letters("a");

            //Assert
            Assert.Equal("A", result);
        }
        [Fact]
        public void Mumble_Letters_ShouldHandleEmptyString()
        {
            //Act
            var result = _mumbling.Mumble_Letters("");

            //Assert
            Assert.Equal("Error, please enter a string", result);
        }

        [Theory]
        [InlineData("ab", "A-Bb")]
        [InlineData("abcde", "A-Bb-Ccc-Dddd-Eeeee")]
        public void Mumbling_Letters_ShouldReturn_XNumberOfYPositionLetter(string inputData, string expectedData)
        {
            //Act
            var result = _mumbling.Mumble_Letters(inputData);

            //Assert
            Assert.Equal(expectedData, result);
        }

    }
}
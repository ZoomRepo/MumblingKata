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
        public void Mumbling_Letters_ShouldReturnFirstCharOfAEachMumbleUpper()
        {
            //Act
            var result = _mumbling.Mumble_Letters("ab");

            //Assert
            Assert.Equal("A-B", result);
        }
     
    }
}
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
        public void Mumble_Letters_Givenab_ShouldReturnA_Bb()
        {
            //Act
            var result = _mumbling.Mumble_Letters("a");

            //Assert
            Assert.Equal("A", result);
        }
    }
}
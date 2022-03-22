using Xunit;

namespace MumblingKata.Tests
{
    public class MumblingKataTest
    {
        [Fact]
        public void Mumble_Letters_ShouldReturnA_WhenGivena()
        {
            //Arrange
            MumblingKata mumbling = new MumblingKata();

            //Act
            var result = mumbling.Mumble_Letters("a");
           
            //Assert
            Assert.Equal("A", result);
        }
    }
}
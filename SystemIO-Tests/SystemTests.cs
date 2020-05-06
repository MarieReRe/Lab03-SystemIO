using System;
using Xunit;


namespace Lab03_SystemIO
{
    public class SystemTests
    {
        [Fact]
        public void GetListTest()
        {
            // Arrange
            string[] inputList = new[] { "black tea" };

            // Act
            string[] resultList = Program.GetList(inputList);

            //Assert
            Assert.Equal(inputList, resultList);
        }
    }
}

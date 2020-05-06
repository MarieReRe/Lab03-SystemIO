using System;
using System.IO;
using Xunit;


namespace Lab03_SystemIO
{
    public class SystemTests
    {
        [Theory]

        //Arrange
        [InlineData("Assets/TeaInventory.txt")]

        public void FileExistsTest(string path)
        {
            // Act
            bool exists = File.Exists(path);

            //Assert
            Assert.True(exists);
        }

        [Fact]
        public void ReadInventoryTest()
        {
            // Arrange
            string path = "Assets/TeaInventory.txt";

            // Act
            string inventory = File.ReadAllText(path);

            // Assert
            Assert.NotEmpty(inventory);
        }
    }
}

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

        [Fact]
        public void CanReadIneventoryLinesTest()
        {
            // Arrange
            string path = "Assets/TeaInventory.txt";

            // Act
            string[] items = File.ReadAllLines(path);

            // Assert
            Assert.Contains( "Black Tea", items);
        }
        [Fact]
        public void AddToInventoryTest()
        {
            //Arrage
            string path = "Assets/TeaInventory.txt";
            string[] newTea = new[] {"Rose Hibiscus" };

            //Act
            File.AppendAllLines(path, newTea);

            // Assert
            Assert.True(File.Exists(path));
            Assert.Contains("Rose Hibiscus", File.ReadAllLines(path));


        }
    }
}

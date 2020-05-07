using System;
using System.IO;
using Xunit;


namespace Lab03_SystemIO
{
    public class SystemTests
    {
        [Theory]

        //Arrange
        [InlineData("Assets/FileExists_TeaInventory.txt")]

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
            string path = "Assets/ReadInventory_TeaInventory.txt";

            // Act
            string inventory = File.ReadAllText(path);

            // Assert
            Assert.NotEmpty(inventory);

        }

        [Fact]
        public void CanReadIneventoryLinesTest()
        {
            // Arrange
            string path = "Assets/CanReadInventory_TeaInventory.txt";

            // Act
            string[] items = File.ReadAllLines(path);

            // Assert
            Assert.Contains("Black Tea", items);
        }
        [Fact]
        public void AddToInventoryTest()
        {
            //Arrage
            string path = "Assets/AddToInventory_TeaInventory.txt";
            string[] newTea = new[] { "Rose Hibiscus" };

            //Act
            File.AppendAllLines(path, newTea);

            // Assert
            Assert.True(File.Exists(path));
            Assert.Contains("Rose Hibiscus", File.ReadAllLines(path));


        }

        [Fact]
        public void RemoveFromInventoryTest()
        {
            // Arrange
            string path = "Assets/RemoveFromInventory_TeaInventory.txt";
      

            // Act
            Program.RemoveTea(path, "Tea3");

            // Assert
            Assert.Equal(new[] { "Tea1", "Tea2" }, File.ReadAllLines(path));
        }

        [Theory]
        [InlineData(new[] { "Tea1", "Tea2" }, "Tea1", new[] { "Tea2" })]

        public void RemoveFromArrayTest(string[] array, string value, string[] expected)
        {
            // Act
            string[] result = Program.RemoveItemFromArray(array, value);

            //Assert
            Assert.Equal(expected, result);
            Assert.NotSame(array, result);
        }
    }
}

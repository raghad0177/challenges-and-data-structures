namespace Common_Elements_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            // Arrange
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };

            int[] arr3 = { 79, 8, 15 };
            int[] arr4 = { 23, 79, 8 };

            // Act
            int[] Case1 = Common_Elements.Program.CommonElements(arr1, arr2);
            int[] Case2 = Common_Elements.Program.CommonElements(arr3, arr4);

            // Assert
            Assert.Equal(2, Case1.Length);
            Assert.Equal(2, Case2.Length);

        }
    }
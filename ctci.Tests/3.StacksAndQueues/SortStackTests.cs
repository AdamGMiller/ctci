namespace citi.Tests._3.StacksAndQueues
{
    using ctci._3.StacksAndQueues;

    public class SortStackTests
    {
        [Fact]
        public void SortsAsExpected()
        {
            // Arrange
            var stack = new SortStack();

            // Act
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(1);

            // Assert
            Assert.Equal(4, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void ShowAsEmptyAsAsExpected()
        {
            // Arrange
            var stack = new SortStack();

            // Act
            var isEmptyBeforeAdd = stack.IsEmpty();
            stack.Push(1);
            var isEmptyAfterAdd = stack.IsEmpty();

            // Assert
            Assert.True(isEmptyBeforeAdd);
            Assert.False(isEmptyAfterAdd);
        }
    }
}
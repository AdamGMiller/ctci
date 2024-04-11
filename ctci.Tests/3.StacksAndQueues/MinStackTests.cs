namespace citi.Tests._3.StacksAndQueues
{
    public class MinStackTests
    {
        [Fact]
        public void CanFindMinStack()
        {
            // Arrange
            var minStack = new MinStack();

            // Act
            minStack.Push(10);
            var minAfterPush1 = minStack.Min();
            minStack.Push(3);
            var minAfterPush2 = minStack.Min();
            minStack.Push(5);
            var minAfterPush3 = minStack.Min();
            minStack.Push(1);
            var minAfterPush4 = minStack.Min();
            minStack.Pop();
            var minAfterPop1 = minStack.Min();
            minStack.Pop();
            var minAfterPop2 = minStack.Min();
            minStack.Pop();
            var minAfterPop3 = minStack.Min();

            // Assert
            Assert.Equal(10, minAfterPush1);
            Assert.Equal(3, minAfterPush2);
            Assert.Equal(3, minAfterPush3);
            Assert.Equal(1, minAfterPush4);
            Assert.Equal(3, minAfterPop1);
            Assert.Equal(3, minAfterPop2);
            Assert.Equal(10, minAfterPop3);
        }

        [Fact]
        public void CanFindMinStackWithDuplicates()
        {
            // Arrange
            var minStack = new MinStack();

            // Act
            minStack.Push(10);
            var minAfterPush1 = minStack.Min();
            minStack.Push(3);
            var minAfterPush2 = minStack.Min();
            minStack.Push(3);
            var minAfterPush3 = minStack.Min();
            minStack.Push(1);
            var minAfterPush4 = minStack.Min();
            minStack.Pop();
            var minAfterPop1 = minStack.Min();
            minStack.Pop();
            var minAfterPop2 = minStack.Min();
            minStack.Pop();
            var minAfterPop3 = minStack.Min();

            // Assert
            Assert.Equal(10, minAfterPush1);
            Assert.Equal(3, minAfterPush2);
            Assert.Equal(3, minAfterPush3);
            Assert.Equal(1, minAfterPush4);
            Assert.Equal(3, minAfterPop1);
            Assert.Equal(3, minAfterPop2);
            Assert.Equal(10, minAfterPop3);
        }
    }
}
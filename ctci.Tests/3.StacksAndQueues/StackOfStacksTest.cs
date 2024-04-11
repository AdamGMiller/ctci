namespace citi.Tests._3.StacksAndQueues
{
    public class StackOfStacksTests
    {
        [Fact]
        public void CanPushAndPopToStackOfStacks()
        {
            // Arrange
            var stack = new StackOfStacks(3);

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var peekAfterPushes1 = stack.Peek();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            var peekAfterPops1 = stack.Peek();

            // Assert
            Assert.Equal(5, peekAfterPushes1);
            Assert.Equal(2, peekAfterPops1);
        }

        [Fact]
        public void GetPopFromIndex()
        {
            // Arrange
            var stack = new StackOfStacks(3);

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var peekAfterPushes1 = stack.Peek();

            var poppedFrom0 = stack.PopAt(0);

            stack.Pop();
            stack.Pop();
            var peekAfterPops1 = stack.Peek();

            // Assert
            Assert.Equal(5, peekAfterPushes1);
            Assert.Equal(3, poppedFrom0);
            Assert.Equal(2, peekAfterPops1);
            Assert.Throws<InvalidOperationException>(() => stack.PopAt(1));
        }

        [Fact]
        public void GetPopFromIndexWithLargeNumber()
        {
            // Arrange
            var stack = new StackOfStacks(3);

            // Act
            for (var i = 0; i < 6; i++)
            {
                stack.Push(i);
            }

            var poppedFrom0 = stack.PopAt(0);
            var poppedFrom1 = stack.PopAt(0);
            var poppedFrom2 = stack.PopAt(0);
            var poppedFrom3 = stack.PopAt(0);

            // Assert
            Assert.Equal(2, poppedFrom0);
            Assert.Equal(1, poppedFrom1);
            Assert.Equal(0, poppedFrom2);
            Assert.Equal(5, poppedFrom3);
            Assert.Throws<InvalidOperationException>(() => stack.PopAt(1));
            Assert.Throws<InvalidOperationException>(() => stack.PopAt(-1));
        }
    }
}
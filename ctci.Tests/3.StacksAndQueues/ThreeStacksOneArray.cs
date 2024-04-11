namespace citi.Tests._2.StacksAndQueues
{
    using citi.Tests._3.StacksAndQueues;

    public partial class StacksAndQueuesTests
    {
        [Fact]
        public void CanPushToAllStacks()
        {
            // Arrange
            var multiStack = new MultiStack(10);

            // Act
            var isEmptyBeforePush0 = multiStack.IsEmpty(0);
            var isEmptyBeforePush1 = multiStack.IsEmpty(1);
            var isEmptyBeforePush2 = multiStack.IsEmpty(2);
            multiStack.Push(0, 1);
            multiStack.Push(1, 2);
            multiStack.Push(2, 3);
            var peek0 = multiStack.Peek(0);
            var peek1 = multiStack.Peek(1);
            var peek2 = multiStack.Peek(2);
            var isEmptyAfterPush0 = multiStack.IsEmpty(0);
            var isEmptyAfterPush1 = multiStack.IsEmpty(1);
            var isEmptyAfterPush2 = multiStack.IsEmpty(2);

            // Assert
            Assert.Equal(1, peek0);
            Assert.Equal(2, peek1);
            Assert.Equal(3, peek2);

            Assert.True(isEmptyBeforePush0);
            Assert.True(isEmptyBeforePush1);
            Assert.True(isEmptyBeforePush2);
            Assert.False(isEmptyAfterPush0);
            Assert.False(isEmptyAfterPush1);
            Assert.False(isEmptyAfterPush2);
        }

        [Fact]
        public void CanPushAndPopAsExpected()
        {
            // Arrange
            var multiStack = new MultiStack(10);

            // Act
            multiStack.Push(1, 1);
            multiStack.Push(1, 2);
            multiStack.Push(1, 3);
            var peekAfterPushes = multiStack.Peek(1);
            multiStack.Pop(1);
            multiStack.Pop(1);
            var peekAfterPops = multiStack.Peek(1);

            // Assert
            Assert.Equal(3, peekAfterPushes);
            Assert.Equal(1, peekAfterPops);
        }

        [Fact]
        public void TestRemoveFromEmptyQueue()
        {
            var multiStack = new MultiStack(10);
            Assert.Throws<InvalidOperationException>(() => multiStack.Pop(1));
        }

        [Fact]
        public void TestPeekAtEmptyQueue()
        {
            var multiStack = new MultiStack(10);
            Assert.Throws<InvalidOperationException>(() => multiStack.Peek(1));
        }

        [Fact]
        public void TestExceptionsBeyondCapacity()
        {
            var multiStack = new MultiStack(10);
            Assert.Throws<InvalidOperationException>(() => multiStack.Peek(4));
            Assert.Throws<InvalidOperationException>(() => multiStack.Pop(4));
            Assert.Throws<InvalidOperationException>(() => multiStack.Push(4, 1));
        }

        [Fact]
        public void TestExceptionWhenExceedingCapacity()
        {
            var multiStack = new MultiStack(3);
            multiStack.Push(1, 1);
            multiStack.Push(1, 1);
            multiStack.Push(1, 1);

            Assert.Throws<InvalidOperationException>(() => multiStack.Push(1, 1));
        }
    }
}
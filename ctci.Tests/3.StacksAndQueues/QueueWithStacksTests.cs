namespace citi.Tests._3.StacksAndQueues
{
    using ctci._3.StacksAndQueues;

    public class QueueWithStacksTests
    {
        [Fact]
        public void QueueWorksAsExpected()
        {
            // Arrange
            var queue = new QueueWithStacks<int>();

            // Act
            var isEmptyBeforeAdd = queue.IsEmpty();
            queue.Add(1);
            var isEmptyAfterAdd = queue.IsEmpty();
            queue.Add(2);
            queue.Add(3);
            var peekAfterAdds = queue.Peek();
            queue.Remove();
            var peekAfterRemove = queue.Peek();
            queue.Add(4);
            var peekAfterSecondAdd = queue.Peek();

            // Assert
            Assert.True(isEmptyBeforeAdd);
            Assert.False(isEmptyAfterAdd);
            Assert.Equal(1, peekAfterAdds);
            Assert.Equal(2, peekAfterRemove);
            Assert.Equal(2, peekAfterSecondAdd);
        }

        [Fact]
        public void QueueThrowsExceptionIfEmpty()
        {
            // Arrange
            var queue = new QueueWithStacks<int>();

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => queue.Remove());
        }
    }
}
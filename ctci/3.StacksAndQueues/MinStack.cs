namespace citi.Tests._3.StacksAndQueues
{
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();

        private Stack<int> minStack = new Stack<int>();

        public void Push(int item)
        {
            this.stack.Push(item);

            if (this.minStack.Count == 0 || item <= this.minStack.Peek())
            {
                this.minStack.Push(item);
            }
        }

        public int Pop()
        {
            if (this.stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var item = this.stack.Pop();

            if (item == this.minStack.Peek())
            {
                this.minStack.Pop();
            }

            return item;
        }

        public int Min()
        {
            if (this.minStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return this.minStack.Peek();
        }
    }}

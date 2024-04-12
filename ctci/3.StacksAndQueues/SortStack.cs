namespace ctci._3.StacksAndQueues
{
    public class SortStack
    {
        private Stack<int> stack;

        public SortStack()
        {
            this.stack = new Stack<int>();
        }

        public void Push(int value)
        {
            var tempStack = new Stack<int>();
            while (this.stack.Count > 0 && this.stack.Peek() > value)
            {
                tempStack.Push(this.stack.Pop());
            }

            this.stack.Push(value);
            while (tempStack.Count > 0)
            {
                this.stack.Push(tempStack.Pop());
            }
        }

        public int Pop() => this.stack.Pop();

        public int Peek() => this.stack.Peek();

        public bool IsEmpty() => this.stack.Count == 0;
    }
}

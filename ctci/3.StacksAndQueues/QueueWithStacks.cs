namespace ctci._3.StacksAndQueues
{
    public class QueueWithStacks<T>
    {
        private Stack<T> stackNewest, stackOldest;

        public QueueWithStacks()
        {
            this.stackNewest = new Stack<T>();
            this.stackOldest = new Stack<T>();
        }

        public int Size() => this.stackNewest.Count + this.stackOldest.Count;

        public void Add(T value)
        {
            this.stackNewest.Push(value);
        }

        public T Peek()
        {
            this.ShiftStacks();
            return this.stackOldest.Peek();
        }

        public T Remove()
        {
            this.ShiftStacks();
            return this.stackOldest.Pop();
        }

        public bool IsEmpty() => this.Size() == 0;

        private void ShiftStacks()
        {
            if (this.stackOldest.Count == 0)
            {
                while (this.stackNewest.Count != 0)
                {
                    this.stackOldest.Push(this.stackNewest.Pop());
                }
            }
        }
    }
}
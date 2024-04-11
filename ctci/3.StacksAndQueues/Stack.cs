namespace ctci._3.StacksAndQueues
{
    public class Stack<T>
    {
        private class StackNode
        {
            public T data;
            public StackNode next;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode top;

        public T Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty.");
            T item = top.data;
            top = top.next;
            return item;
        }

        public void Push(T item)
        {
            StackNode t = new StackNode(item);
            t.next = top;
            top = t;
        }

        public T Peek()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty.");
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
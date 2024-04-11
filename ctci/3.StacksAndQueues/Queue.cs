namespace ctci._3.StacksAndQueues
{
    public class Queue<T>
    {
        private class QueueNode
        {
            public T data;
            public QueueNode next;

            public QueueNode(T data)
            {
                this.data = data;
            }
        }

        private QueueNode first;
        private QueueNode last;

        public void Add(T item)
        {
            QueueNode t = new QueueNode(item);
            if (last != null)
            {
                last.next = t;
            }
            last = t;
            if (first == null)
            {
                first = last;
            }
        }

        public T Remove()
        {
            if (first == null) throw new InvalidOperationException("Queue is empty.");
            T data = first.data;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            return data;
        }

        public T Peek()
        {
            if (first == null) throw new InvalidOperationException("Queue is empty.");
            return first.data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
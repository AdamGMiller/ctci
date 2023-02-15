namespace ctci._2.LinkedLists
{
    public class Node
    {
        public Node? next = null;
        public int data;

        public Node(int d)
        {
            data = d;
        }

        public void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }

        public Node deleteNode(Node head, int d)
        {
            Node n = head;

            if (n.data == d)
            {
                return head.next; /* moved head*/
            }

            while (n.next != null)
            {
                if (n.next.data == d)
                {
                    n.next = n.next.next;
                    return head; /* head didn't change*/
                }
                n = n.next;
            }
            return head;
        }

        public int[] GetData()
        {
            List<int> data = new List<int>();
            var node = this;
            while(node != null) {
                data.Add(node.data);
                node = node.next;
            }

            return data.ToArray();
        }
    }
}
namespace ctci._2.LinkedLists
{
    public class RemoveMiddle
    {
        public bool RemoveItemFromLinkedList(Node node)
        {
            if(node == null || node.next == null)
            {
                return false;
            }

            var nextNode = node.next;
            node.data = nextNode.data;
            node.next = nextNode.next;

            return true;

        }
    }
}

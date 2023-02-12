namespace ctci._2.LinkedLists
{
    public class RemoveDups
    {
        public Node GetUniqueItems(Node node)
        {
            var dictionary = new Dictionary<int, Node>();

            Node? previousNode = null;
            var currentNode = node;

            while (currentNode != null)
            {
                if(dictionary.TryAdd(currentNode.data, currentNode))
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }
                else
                {
                    previousNode.next = currentNode.next;
                    currentNode = currentNode.next?.next;
                }

            }

            return node;
        }
    }
}

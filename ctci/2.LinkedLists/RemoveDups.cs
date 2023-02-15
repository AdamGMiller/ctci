namespace ctci._2.LinkedLists
{
    public class RemoveDups
    {
        public Node GetUniqueItems(Node node)
        {
            var nodeValues = new HashSet<int>();

            Node lastValidNode = node;
            var currentNode = node;

            while (currentNode != null)
            {
                if (nodeValues.Add(currentNode.data))
                {
                    lastValidNode = currentNode;
                }

                currentNode = currentNode.next;

                lastValidNode.next = currentNode;
            }

            return node;
        }
    }
}

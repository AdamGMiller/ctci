namespace ctci._2.LinkedLists
{
    public class LoopDetection
    {
        public Node? GetLoopingNode(Node node)
        {
            var nodes = new HashSet<Node>();
            return this.AddLinkedListAndGetIntersectionIfFound(node, nodes);
        }

        private Node? AddLinkedListAndGetIntersectionIfFound(Node node, HashSet<Node> nodes)
        {
            var currentNode = node;
            while (currentNode != null)
            {
                var success = nodes.Add(currentNode);

                if (!success)
                {
                    return currentNode;
                }

                currentNode = currentNode.next;
            }

            return (Node?)null;
        }
    }
}

namespace ctci._2.LinkedLists
{
    public class Intersection
    {
        public Node? GetIntersectingNode(Node firstNode, Node secondNode)
        {
            var nodes = new HashSet<Node>();
            this.AddLinkedListAndGetIntersectionIfFound(firstNode, nodes);
            return this.AddLinkedListAndGetIntersectionIfFound(secondNode, nodes);
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

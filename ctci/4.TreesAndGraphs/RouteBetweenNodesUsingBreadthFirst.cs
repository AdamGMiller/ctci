namespace ctci._4.TreesAndGraphs
{
    public class RouteBetweenNodesUsingBreadthFirst
    {
        public bool IsPathBetweenNodesUsingBreadthFirst(Graph graph, Node start, Node end)
        {
            if (start == end)
            {
                return true;
            }

            var queue = new Queue<Node>();
            start.Visited = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == end)
                {
                    return true;
                }

                var found = this.VisitUnvisitedChildren(node, end, queue);
                if (found != null)
                {
                    return true;
                }
            }

            return false;
        }

        private Node VisitUnvisitedChildren(Node node, Node end, Queue<Node> queue)
        {
            if (node.Children != null)
            {
                foreach (var child in node.Children)
                {
                    if (child == end)
                    {
                        return child;
                    }

                    if (!child.Visited)
                    {
                        child.Visited = true;
                        queue.Enqueue(child);
                    }
                }
            }
            return null;
        }
    }
}

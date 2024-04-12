namespace ctci._4.TreesAndGraphs
{
    public class RouteBetweenNodesUsingDepthFirst
    {
        private bool depthFirstFound = false;

        private Node end;

        public bool IsPathBetweenNodesUsingDepthFirst(Graph graph, Node start, Node end)
        {
            if (start == end)
            {
                return true;
            }

            this.depthFirstFound = false;
            this.end = end;
            start.Visited = true;
            this.VisitUnvisitedChildren(start);
            return this.depthFirstFound;
        }

        private Node VisitUnvisitedChildren(Node node)
        {
            if (node.Children != null)
            {
                foreach (var child in node.Children)
                {
                    if (child == this.end)
                    {
                        this.depthFirstFound = true;
                        return null;
                    }

                    if (!child.Visited)
                    {
                        child.Visited = true;
                        this.VisitUnvisitedChildren(child);
                    }
                }
            }
            return null;
        }
    }
}

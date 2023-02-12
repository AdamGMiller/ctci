namespace ctci._2.LinkedLists
{
    public class GetKthToLast
    {
        public Node? GetNodeFromEnd(Node node, int k)
        {
            int depth = 0;
            Node? trailingNode = null;
            var currentNode = node;

            while (currentNode != null)
            {
                SetTrailingNodeToRootNodeIfDepthPassed();
                if (CurrentNodeIsAtEndOfList())
                {
                    return trailingNode;
                };
                IncreaseDepthAndMoveNodes();
            }
            return trailingNode;

            void SetTrailingNodeToRootNodeIfDepthPassed()
            {
                if (depth == k)
                {
                    trailingNode = node;
                }
            }

            bool CurrentNodeIsAtEndOfList()
            {
                return (currentNode?.next == null);
            }

            void IncreaseDepthAndMoveNodes()
            {
                currentNode = currentNode?.next;

                if (trailingNode != null)
                {
                    trailingNode = trailingNode.next;
                }

                depth++;
            }
        }
    }
}

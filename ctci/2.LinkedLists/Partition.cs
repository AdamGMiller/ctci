namespace ctci._2.LinkedLists
{
    public class Partition
    {
        public Node PartitionAroundValue(Node node, int value)
        {
            var lowNode = (Node?)null;
            var lastLowNode = (Node?)null;
            var highNode = (Node?)null;

            var currentNode = node;

            while (currentNode != null)
            {
                if (currentNode.data < value)
                {
                    if (lowNode == null)
                    {
                        lowNode = new Node(currentNode.data);
                        lastLowNode = lowNode;
                    }
                    else
                    {
                        lowNode.appendToTail(currentNode.data);
                        lastLowNode = lastLowNode.next;
                    }
                }
                else
                {
                    if (highNode == null)
                    {
                        highNode = new Node(currentNode.data);
                    }
                    else
                    {
                        highNode.appendToTail(currentNode.data);
                    }
                }

                currentNode = currentNode.next;
            }

            if (lastLowNode != null)
            {
                lastLowNode.next = highNode;
                return lowNode;
            }
            else
            {
                return highNode;
            }
        }
    }
}

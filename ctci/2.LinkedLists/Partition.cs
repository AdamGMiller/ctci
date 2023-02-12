namespace ctci._2.LinkedLists
{
    public class Partition
    {
        public Node PartitionAroundValue(Node node, int value)
        {
            var currentNode = node;

            while (currentNode.next != null)
            {
                if(currentNode.data < value)
                {
                    continue;
                }

                var currentData = currentNode.data;
                currentNode.data = currentNode.next.data;
                currentNode.next.data = currentData;

                currentNode = currentNode.next;
            }

            return node;
        }
    }
}

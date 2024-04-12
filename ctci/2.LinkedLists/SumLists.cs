namespace ctci._2.LinkedLists
{
    public class SumLists
    {
        public Node? SumNumbersStoredInReverseOrder(Node? firstNode, Node? secondNode)
        {
            var carryTen = false;
            var outputNode = (Node?)null;
            while(firstNode != null || secondNode != null)
            {
                var digitValue = (firstNode?.data ?? 0) + (secondNode?.data ?? 0) + (carryTen ? 1 : 0);
                carryTen = digitValue > 9;
                var valueToStoreInNode = digitValue % 10;
                if(outputNode == null)
                {
                    outputNode = new Node(valueToStoreInNode);
                } else
                {
                    outputNode.AppendToTail(valueToStoreInNode);
                }

                firstNode = firstNode?.next;
                secondNode = secondNode?.next;
            }

            if(carryTen)
            {
                outputNode.AppendToTail(1);
            }

            return outputNode;
        }
    }
}

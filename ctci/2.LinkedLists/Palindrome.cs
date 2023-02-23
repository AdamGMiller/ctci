namespace ctci._2.LinkedLists
{
    public class Palindrome
    {
        public bool IsPalindrome(Node firstNode)
        {
            Node currentNode = firstNode;
            var nodes = new List<int>();
            int nodeCount = 0;

            while (currentNode != null)
            {
                nodes.Add(currentNode.data);
                nodeCount++;
                currentNode = currentNode.next;
            }

            // Ignore the middle value if there are an odd number of items
            var palindromeLength = (int)Math.Floor(nodeCount / 2f);
            var firstHalf = nodes.Take(palindromeLength);
            var secondHalf = nodes.TakeLast(palindromeLength).Reverse();

            return firstHalf.SequenceEqual(secondHalf);
        }
    }
}

using System.Collections.Generic;

namespace ctci._4.TreesAndGraphs
{
    public class BinarySearchTreeValidatorTransversal
    {
        private TreeNode root;

        public BinarySearchTreeValidatorTransversal(TreeNode root)
        {
            this.root = root;
        }

        public bool IsValid()
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode currentNode = root;
            TreeNode previousNode = null;

            while (currentNode != null || stack.Count > 0)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();

                if (previousNode != null && currentNode.Data <= previousNode.Data)
                {
                    return false;
                }

                previousNode = currentNode;
                currentNode = currentNode.Right;
            }

            return true;
        }
    }
}

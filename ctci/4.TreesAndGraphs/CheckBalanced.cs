namespace ctci._4.TreesAndGraphs
{
    public class CheckBalanced
    {
        private TreeNode root;

        private bool isBalanced;

        private int nodeDepth;

        private int maximumNodeDepth;

        /*
         * Strategy: use depth-first searching and determine the depth of the first node.
         * If any other leaf nodes aren't at that depth or if the depth exceeds that depth,
         * the tree is not balanced
         */
        public CheckBalanced(TreeNode root)
        {
            this.root = root;
            this.isBalanced = true;
            this.nodeDepth = 0;
            this.maximumNodeDepth = 0;
        }

        public bool IsBalanced()
        {
            this.CheckIfNodeIsBalanced(this.root, this.nodeDepth);

            return this.isBalanced;
        }

        private TreeNode? CheckIfNodeIsBalanced(TreeNode node, int nodeDepth)
        {
            if (!this.isBalanced)
            {
                return null;
            }

            if (this.nodeDepth > this.maximumNodeDepth)
            {
                this.isBalanced = false;
                return null;
            }

            if (node.Left == null && node.Right == null)
            {
                if (this.maximumNodeDepth == 0)
                {
                    this.maximumNodeDepth = nodeDepth;
                }
                else
                {
                    if (this.maximumNodeDepth != nodeDepth)
                    {
                        this.isBalanced = false;
                        return null;
                    }
                }
                return null;
            }

            nodeDepth++;
            if (node.Left != null)
            {
                this.CheckIfNodeIsBalanced(node.Left, nodeDepth);
            }

            if (node.Right != null)
            {
                this.CheckIfNodeIsBalanced(node.Right, nodeDepth);
            }

            return null;
        }
    }
}

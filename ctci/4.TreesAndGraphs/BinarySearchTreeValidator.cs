namespace ctci._4.TreesAndGraphs
{
    public class BinarySearchTreeValidator(TreeNode root)
    {
        private int largestValue = root.Data;

        private bool isValid = true;

        public bool IsValid()
        {
            var max = this.MaxOfChildNodes(root);
            return this.isValid;
        }

        private int MaxOfChildNodes(TreeNode node)
        {
            if (this.isValid == false)
            {
                return Int32.MinValue;
            }

            var leftMax = (int?)null;
            var rightMax = (int?)null;
            if (node.Left != null)
            {
                leftMax = this.MaxOfChildNodes(node.Left);
            }
            if (node.Right != null)
            {
                rightMax = this.MaxOfChildNodes(node.Right);
            }

            if ((leftMax != null && leftMax > node.Data) || (rightMax != null && rightMax <= node.Data))
            {
                this.isValid = false;
                return Int32.MinValue;
            }

            int[] values = [node.Data, leftMax ?? int.MinValue, rightMax ?? int.MinValue];
            return values.Max();
        }
    }
}

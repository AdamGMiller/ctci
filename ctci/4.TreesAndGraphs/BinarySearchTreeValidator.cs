namespace ctci._4.TreesAndGraphs
{
    public class BinarySearchTreeValidator(TreeNode root)
    {
        private bool isValid = true;

        public bool IsValid()
        {
            this.MaxOfChildNodes(root);
            return this.isValid;
        }

        private int MaxOfChildNodes(TreeNode node)
        {
            if (this.isValid == false)
            {
                return int.MinValue;
            }

            if (node.Left != null)
            {
                int? leftMax = this.MaxOfChildNodes(node.Left);
                if (leftMax > node.Data)
                {
                    this.isValid = false;
                    return int.MinValue;
                }
            }

            if (node.Right == null)
            {
                return node.Data;
            }

            int? rightMax = this.MaxOfChildNodes(node.Right);
            if (rightMax <= node.Data)
            {
                this.isValid = false;
                return int.MinValue;
            }
            else
            {
                return rightMax.Value;
            }
        }
    }
}

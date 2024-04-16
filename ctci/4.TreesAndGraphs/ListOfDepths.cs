namespace ctci._4.TreesAndGraphs
{
    public class ListOfDepths
    {
        private TreeNode root { get; set; }

        public List<LinkedList<TreeNode>> Depths;

        public ListOfDepths(TreeNode root)
        {
            this.root = root;
            this.Depths = new List<LinkedList<TreeNode>>();
            this.CreateLinkedLists(this.root, 0);
        }

        private void CreateLinkedLists(TreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            if (this.Depths.Count <= depth)
            {
                this.Depths.Add(new LinkedList<TreeNode>());
            }

            this.Depths[depth].AddLast(node);

            this.CreateLinkedLists(node.Left, depth + 1);
            this.CreateLinkedLists(node.Right, depth + 1);
        }

    }
}

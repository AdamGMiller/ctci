namespace ctci._4.TreesAndGraphs
{
    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode? Left { get; set; }

        public TreeNode? Right { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}

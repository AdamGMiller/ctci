namespace ctci._4.TreesAndGraphs
{
    public class MinimalTree
    {
        private TreeNode root { get; set; }

        public MinimalTree(int[] sortedArray)
        {
            this.CreateMinimalTree(sortedArray);
        }

        public int GetActualTreeHeight()
        {
            int treeHeight = 1;
            var searchNode = this.root;
            while (searchNode.Left != null)
            {
                treeHeight++;
                searchNode = searchNode.Left;
            }

            return treeHeight;
        }

        public int GetOptimalTreeHeight(int valuesCount)
        {
            return (int)Math.Ceiling(Math.Log(valuesCount + 1, 2));
        }

        private void CreateMinimalTree(int[] sortedArray)
        {
            var index = 0;
            var height = 0;

            var node = this.root;
            this.AddNode(node, sortedArray, index, height);
        }

        private void AddNode(TreeNode node, int[] sortedArray, int index, int height)
        {
            if (height == 0)
            {
                this.root = new TreeNode(sortedArray[index]);
                node = this.root;
            }

            var leftIndex = index + (int)Math.Pow(2, height);
            var rightIndex = index + (int)Math.Pow(2, height + 1);

            if (leftIndex < sortedArray.Length)
            {
                node.Left = new TreeNode(sortedArray[leftIndex]);
                this.AddNode(node.Left, sortedArray, leftIndex, height + 1);
            }

            if (rightIndex < sortedArray.Length)
            {
                node.Right = new TreeNode(sortedArray[rightIndex]);
                this.AddNode(node.Right, sortedArray, rightIndex, height + 1);
            }
        }
    }
}

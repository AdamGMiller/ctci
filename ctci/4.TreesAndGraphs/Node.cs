namespace ctci._4.TreesAndGraphs
{
    public class Node
    {
        public string Name { get; set; }
        public Node[] Children { get; set; }
        public bool Visited { get; set; }

        public Node(string name)
        {
            this.Name = name;
        }
    }
}

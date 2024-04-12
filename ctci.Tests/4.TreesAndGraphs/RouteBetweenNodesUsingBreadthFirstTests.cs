namespace citi.Tests._3.StacksAndQueues
{
    using ctci._4.TreesAndGraphs;

    public class RouteBetweenNodesUsingBreadthFirstTests
    {
        [Fact]
        public void CanDetermineRouteAsExpectedWhereRouteExists()
        {
            // Arrange
            var graph = new Graph();
            var node1 = new Node("Node1");
            var node2 = new Node("Node2");
            var node3 = new Node("Node3");
            node1.Children = new Node[] { node2, node3 };
            var node4 = new Node("Node4");
            graph.nodes = new Node[] { node1, node4 };

            // Act
            var route = new RouteBetweenNodesUsingBreadthFirst();
            var isRoute = route.IsPathBetweenNodesUsingBreadthFirst(graph, node1, node3);

            // Assert
            Assert.True(isRoute);
        }

        [Fact]
        public void CanDetermineRouteAsExpectedWhereRouteDoesNotExist()
        {
            // Arrange
            var graph = new Graph();
            var node1 = new Node("Node1");
            var node2 = new Node("Node2");
            var node3 = new Node("Node3");
            node1.Children = new Node[] { node2, node3 };
            var node4 = new Node("Node4");
            graph.nodes = new Node[] { node1, node4 };

            // Act
            var route = new RouteBetweenNodesUsingBreadthFirst();
            var isRoute = route.IsPathBetweenNodesUsingBreadthFirst(graph, node1, node4);

            // Assert
            Assert.False(isRoute);
        }

        [Fact]
        public void CanDetermineRouteAsExpectedWhereRouteExistsAndNodesLoop()
        {
            // Arrange
            var graph = new Graph();
            var node1 = new Node("Node1");
            var node2 = new Node("Node2");
            var node3 = new Node("Node3");
            node3.Children = new Node[] { node1 };
            node1.Children = new Node[] { node2, node3 };
            var node4 = new Node("Node4");
            graph.nodes = new Node[] { node1, node4 };

            // Act
            var route = new RouteBetweenNodesUsingBreadthFirst();
            var isRoute = route.IsPathBetweenNodesUsingBreadthFirst(graph, node1, node3);

            // Assert
            Assert.True(isRoute);
        }

    }
}

using System;

namespace Demo.TreeTraversing.ConsoleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Node rootNode = BuildCompleteTree();

			//VisitPreOrder(rootNode);
			//ProcessInOrder(rootNode);
			ProcessPostOrder(rootNode);
		}

		private static void ProcessPostOrder(Node currentNode)
		{
			if (currentNode == null) return;

			ProcessPostOrder(currentNode.Left);
			ProcessPostOrder(currentNode.Right);
			Process(currentNode.Value);
		}

		private static void ProcessInOrder(Node currentNode)
		{
			if (currentNode == null) return;

			ProcessInOrder(currentNode.Left);
			Process(currentNode.Value);
			ProcessInOrder(currentNode.Right);
		}

		private static void VisitPreOrder(Node currentNode)
		{
			if (currentNode == null) return;

			Process(currentNode.Value);
			VisitPreOrder(currentNode.Left);
			VisitPreOrder(currentNode.Right);
		}

		private static void Process(int value)
		{
			Console.Write("{0} ", value);
		}

		/// <summary>
		/// Build a tree structure that looks like this
		/// 
		///					n4
		///			n2				n6
		///		n1		n3		n5		n7
		/// </summary>
		/// <returns></returns>
		private static Node BuildCompleteTree()
		{
			// Leaf Nodes
			Node n1 = new Node(null, 1, null);
			Node n3 = new Node(null, 3, null);
			Node n5 = new Node(null, 5, null);
			Node n7 = new Node(null, 7, null);

			// Middle Nodes
			Node n2 = new Node(n1, 2, n3);
			Node n6 = new Node(n5, 6, n7);

			// Root Node
			Node n4 = new Node(n2, 4, n6);

			return n4;
		}
	}

	public class Node
	{
		public Node Left { get; set; }
		public int Value { get; set; }
		public Node Right { get; set; }

		public Node(Node left, int value, Node right)
		{
			Left = left;
			Value = value;
			Right = right;
		}
	}
}

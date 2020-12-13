using System;

namespace BinaryTreeHeight
{ 
    public class BinaryTree
    {
        Node rootNode;
        public static void Main()
        {
            BinaryTree tree = new BinaryTree();
            tree.rootNode = new Node(5);
            tree.rootNode.left = new Node(6);
            tree.rootNode.right = new Node(7);
            tree.rootNode.left.left = new Node(9);
            tree.rootNode.left.left.right = new Node(5);
            tree.rootNode.left.left.right.left = new Node(5);

            Console.WriteLine("Gjatesia e pemës është: " + tree.getTreeDepth(tree.rootNode));
        }

        int getTreeDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int leftDepth = getTreeDepth(node.left);
                int rightDepth = getTreeDepth(node.right);

                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }
    }
}
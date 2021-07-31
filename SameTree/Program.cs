using System;

namespace SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree1 = new Node(10);
            tree1.left = new Node(12);
            tree1.right = new Node(13);
            tree1.right.left = new Node(15);
            tree1.right.right = new Node(14);
            tree1.right.left.right = new Node(16);

            Node tree2 = new Node(10);
            tree2.left = new Node(13);
            tree2.right = new Node(13);
            tree2.right.left = new Node(15);
            tree2.right.right = new Node(14);
            tree2.right.left.right = new Node(16);

            FindSameTree n = new FindSameTree();
            if (n.IsSameTree(tree1 , tree2))
                Console.WriteLine("Same tree");
            else
                Console.WriteLine("Not same tree");

            Console.ReadLine();
        }
    }
}

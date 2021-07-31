using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTree
{
    class FindSameTree
    {
        public bool IsSameTree(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

            return root1.data == root2.data
                    && IsSameTree(root1.left, root2.left)
                    && IsSameTree(root1.right, root2.right);

        }
    }
}

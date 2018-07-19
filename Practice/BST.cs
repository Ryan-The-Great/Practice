using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Node
    {
        public int val;
        public Node left, right;

        public Node(int val)
        {
            this.val = val;
        }
    }
    class BST
    {
        public Node root;

        public BST()
        {
            this.root = null;
        }

        public Node Insert(int val)
        {
            return Insert(this.root, val);
        }

        public Node Insert(Node node, int val)
        {
            if (this.root == null)
            {
                this.root = new Node(val);
                return this.root;
            }
            else if (node == null)
            {
                node = new Node(val);
                return node;
            }
            else
            {
                if (val < node.val)
                    node.left = Insert(node.left, val);
                else if (val > node.val)
                    node.right = Insert(node.right, val);
                return node;
            }
        }

        public bool Search(int val)
        {
            return (Search(this.root, val) != null ? true : false);
        }

        public Node Search(Node node, int val)
        {
            Node result = null;

            if (node == null || val == node.val)
                return node;
            else if (val < node.val)
                result = Search(node.left, val);
            else
                result = Search(node.right, val);
            return result;
        }

        public Node MinValNode()
        {
            if (this.root == null || this.root.left == null)
                return this.root;

            Node cur = root;
            while (cur.left != null)
                cur = cur.left;
            return cur;
        }

        public Node Delete(int val)
        {
            return Delete(root, val);
        }

        public Node Delete(Node node, int val)
        {
            Node target = Search(val);

            i
           
        }

        public void InOrderTraverse()
        {
            InOrder(this.root);
        }

        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.WriteLine(node.val);
                InOrder(node.right);
            }
        }
    }
}

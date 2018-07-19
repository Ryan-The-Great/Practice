using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    using System;

    public class Program
    {
        public static void Main()
        {
            //TestVarScope();
            TestBST();
        }

        public static void TestBST()
        {
            BST bst = new BST();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);
            bst.Insert(40);
            bst.InOrderTraverse();

            Console.WriteLine(String.Format("50 found? {0}",  bst.Search(50)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(40)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(80)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(100)));

            Console.WriteLine(String.Format("Min value in BST is: " + bst.MinValNode().val));
        }

        public static void TestVarScope()
        {
            VarScope.Test();
        }
    }
}

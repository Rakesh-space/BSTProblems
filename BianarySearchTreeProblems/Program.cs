using System;

namespace BianarySearchTreeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            SizeBianarySearchTree<int> bianarySearchTree = new SizeBianarySearchTree<int>(56);
            bianarySearchTree.Insert(30);
            bianarySearchTree.Insert(70);
            bianarySearchTree.display();
            bianarySearchTree.GetSize();
        }
    }
}

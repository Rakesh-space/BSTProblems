using System;

namespace BianarySearchTreeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBianarySearchTree<int> bianarySearchTree = new CreateBianarySearchTree<int>(56);
            bianarySearchTree.Insert(30);
            bianarySearchTree.Insert(70);
            bianarySearchTree.display();
        }
    }
}

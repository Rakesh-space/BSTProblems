using System;

namespace BianarySearchTreeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            SearchBianarySearchTree<int> bianarySearchTree = new SearchBianarySearchTree<int>(56);
            bianarySearchTree.Insert(30);
            bianarySearchTree.Insert(70);
            bianarySearchTree.display();
            bianarySearchTree.GetSize();

            bool resutl = bianarySearchTree.IFExits(67, bianarySearchTree);
            Console.WriteLine("\n result:" + resutl);

            Console.ReadLine();
        }
    }
}

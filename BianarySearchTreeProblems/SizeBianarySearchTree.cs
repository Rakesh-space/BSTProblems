using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTreeProblems
{
    class SizeBianarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get;
            set;
        }
        public SizeBianarySearchTree<T> LeftTree //Generic getter and setter method use here for LeftTree
        {
            get;
            set;
        }
        public SizeBianarySearchTree<T> RightTree //Generic getter and setter method use here for RightTree
        {
            get;
            set;
        }

        public SizeBianarySearchTree(T nodeData) //here Constructore user for initialize the instance vaiables
        {
            this.NodeData = nodeData;  //here node data assigned to instance variable
            this.LeftTree = null;  //here initialy Lefttree node is null
            this.RightTree = null;  //here initialy Righttree node is null
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData; //here create a tree type new node

            if ((currentNodeValue.CompareTo(item)) > 0)  //here compare root data and newData
            {
                if (this.LeftTree == null)  //here lefttree is null then assigned to newNode
                {
                    this.LeftTree = new SizeBianarySearchTree<T>(item);
                }
                else
                    this.LeftTree.Insert(item);  //here lefttree is not null then insert data
            }
            else
            {
                if (this.RightTree == null) //here righttree is null then assigned to newNode
                {
                    this.RightTree = new SizeBianarySearchTree<T>(item);
                }
                else
                    this.RightTree.Insert(item); //here righttree is not null then insert data
            }
        }

        public void display()  //here use Display
        {
            if (this.LeftTree != null)  // till left tree is not 
            {
                this.leftCount++;       //here Count left Node 
                this.LeftTree.display(); //recursive call display method
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)  // till right tree is not
            {
                this.rightCount++;  //here Count right Node
                this.RightTree.display();  //recursive call display method
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }

    }
}

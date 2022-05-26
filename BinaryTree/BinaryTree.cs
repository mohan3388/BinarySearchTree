using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }

        public BinaryTree(T nodeData)
        {
            NodeData = nodeData;
            this.Left = null;
            this.Right = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T CurrentNode = this.NodeData;
            if ((CurrentNode.CompareTo(item)) > 0)
            {
                if (this.Left == null)
                {
                    this.Left = new BinaryTree<T>(item);
                }
                else
                {
                    this.Left.Insert(item);
                }
            }
            else
            {
                if ((this.Right == null))
                {
                    this.Right = new BinaryTree<T>(item);
                }
                else
                {
                    this.Right.Insert(item);
                }
            }
            
        }
        public void Display()
        {
            if (this.Left != null)
            {
                this.leftCount++;
                this.Left.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.Right != null)
            {
                this.rightCount++;
                this.Right.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
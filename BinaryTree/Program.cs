using BinaryTree;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Welcome to Binary Search Tree");
        BinaryTree<int> binarysearch = new BinaryTree<int>(56);
        binarysearch.Insert(30);
        binarysearch.Insert(17);
        binarysearch.Insert(51);
        binarysearch.Insert(63);
        binarysearch.Insert(70);
        binarysearch.Display();
        binarysearch.GetSize();
        bool result = binarysearch.IfExists(63, binarysearch);
        Console.WriteLine(result);
    }
}
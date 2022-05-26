using BinaryTree;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Welcome to Binary Search Tree");
        BinaryTree<int> binarysearch = new BinaryTree<int>(56);
        binarysearch.Insert(30);
        binarysearch.Insert(70);
        binarysearch.Display();

    }
}
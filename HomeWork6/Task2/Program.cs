using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Павлов Василий
    //2. Переписать программу, реализующее двоичное дерево поиска.
    //а) Добавить в него обход дерева различными способами;
    //б) Реализовать поиск в двоичном дереве поиска;
    class BinaryTree
    {
        public int? Data { get; set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Parent { get; set; }

        public void Insert(int data)
        {
            if (Data == null || Data == data)
            {
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (Left == null) Left = new BinaryTree();
                Insert(data, Left, this);
            }
            else
            {
                if (Right == null) Right = new BinaryTree();
                Insert(data, Right, this);
            }
        }
        private void Insert(int data, BinaryTree Node, BinaryTree parent)
        {
            if (Node.Data == null || Node.Data == data)
            {
                Node.Data = data;
                Node.Parent = parent;
                return;
            }
            if (Node.Data > data)
            {
                if (Node.Left == null) Node.Left = new BinaryTree();
                Insert(data, Node.Left, Node);
            }
            else
            {
                if (Node.Right == null) Node.Right = new BinaryTree();
                Insert(data, Node.Right, Node);
            }
        }
        public BinaryTree Find(int data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Find(data, Left);
            }
            return Find(data, Right);
        }
        public BinaryTree Find(int data, BinaryTree Node)
        {
            if (Node.Data == data)
            {
                Console.WriteLine("Значение найдено!");
                return Node;
            }
            if (Node.Data > data)
            {
                return Find(data, Node.Left);
            }
            return Find(data, Node.Right);
        }
        public static void RootLeftRight(BinaryTree node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data);

                RootLeftRight(node.Left);
                RootLeftRight(node.Right);

            }
        }
        public static void LeftRootRight(BinaryTree node)
        {
            if (node != null)
            {
                LeftRootRight(node.Left);
                Console.WriteLine(node.Data);
                LeftRootRight(node.Right);

            }
        }
        public static void LeftRightRoot(BinaryTree node)
        {
            if (node != null)
            {
                LeftRightRoot(node.Left);
                LeftRightRoot(node.Right);
                Console.WriteLine(node.Data);
            }
        }
        static void Main(string[] args)
        {
            var a = new BinaryTree();

            a.Insert(8);
            a.Insert(5);
            a.Insert(9);
            a.Insert(10);
            a.Insert(11);
            a.Insert(6);
            a.Insert(3);


            a.Find(10);


            RootLeftRight(a);
            LeftRootRight(a);
            LeftRightRoot(a);
            Console.ReadKey();
        }
    }
}

using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Add(30);
            list.Add(40);
            int position = list.Search(30);
            list.InsertAtParticularPosition(position+1, 40);
            list.Display();
            int searchDelete = list.Search(40);
            list.DeleteNodeAtParticuarPosition(searchDelete);
            list.Display();
            list.Size();
            list.Display();


            LinkedListStack stack = new LinkedListStack();
            stack.Push(56);
            stack.Push(70);
            stack.Push(30);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
        }

        //BST - Binary Search Tree
        //Delegates
    }
}

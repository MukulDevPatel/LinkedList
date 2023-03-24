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
            int position = list.Search(30);
            list.InsertAtParticularPosition(position+1, 40);
            list.Display();
            int searchDelete = list.Search(40);
            list.DeleteNodeAtParticuarPosition(searchDelete);
            list.Display();
        }

        //BST - Binary Search Tree
        //Delegates
    }
}

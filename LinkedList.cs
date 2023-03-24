using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
        ///<summary>
        ///UC-1
        ///</summary>
        ///<param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        ///<summary>
        ///UC-2
        ///</summary>
        ///<param name="data"></param>
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;//30->70
                head = newNode;//56
                head.next = newNode;//56->30->70
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        ///<summary>
        ///UC-4
        ///</summary>
        ///<param name="position"></param>
        ///<param name="data"></param>
        ///<return></return>
        internal void InsertAtParticularPosition(int position, int data)//56->30
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                this.head = newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
        }
        ///<summary>
        ///UC-5
        ///</summary>
        ///<param name="data"></param>
        internal void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            this.head = this.head.next;
        }
        ///<summary>
        ///UC-6
        ///</summary>
        ///<param name="data"></param>
        internal void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                this.head = null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        ///<summary>
        ///UC-7
        ///</summary>
        ///<param name="value"></param>
        ///<returns></returns>
        internal void Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                node = node.next;
                count++;
            }
        }
    }
}

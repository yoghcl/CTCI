using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DataStructures.LinkedList
{
    public class LinkedListManager<T> 
    {
        public LinkedListNode<T> Head = null;

        public LinkedListManager()
        {

        }

        /// <summary>
        /// Head = 1, Node (2,Null) 
        /// </summary>
        /// <param name="node"></param>
        public void AddNodeToTheBegining(LinkedListNode<T> node)
        {
            //first node in the list
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                //make the new node next as Head
                node.Next = Head;
                Head = node;
            }
        }

        public void PrintNodes()
        {
            var current = Head;
            while (current != null)
            {
                Trace.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void ReverseNode()
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> next = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Head = previous;
        }

    }
}

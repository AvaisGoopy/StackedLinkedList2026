using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackedLinkedList2026
{
    public class StackLL : Interface1
    {
        Node head;



        public bool IsEmpty()
        {
            return head == null;
        }
        public object Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                return head.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public int Pop()
        {
            // check for stack underflow
            if (IsEmpty())
            {
                Console.Write("\nStack Underflow");
                return 0;
            }

            // update the top pointer to
            // point to the next node
            head = (head).next;
            return 0;
        }

        public void Push(int value)
        {
            // create new node temp and allocate memory
            Node temp = new Node();

            // check if stack (heap) is full.
            // Then inserting an element
            // would lead to stack overflow
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
            temp.data = value;

            // put top reference into temp link
            temp.next = head;

            // update top reference
            head = temp;

        }

        public int Size()
        {
            throw new NotImplementedException();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsAndDataStructures.DataStructure
{
    internal class CustomLinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        private int length;
        CustomLinkedList()
        {
            Head = null;
            Tail = null;
            length = 0;
        }
        public int getLength()
        {
            return length;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
        public void AddFirst(T item) 
        {
            Node<T> node = new Node<T>(item);
            if (IsEmpty())
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            length++;
        }
        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            if (IsEmpty())
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            length++;
        }
    }
}

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
        public CustomLinkedList()
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
        public void AddBefore(T item, int pos)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty..");
            }
            else if (pos >= length||pos<0) 
            {
                Console.WriteLine("Position out of range");
            }
            else
            {
                if(pos==0)
                    AddFirst(item);
                if(pos==length)
                    AddLast(item);
                else
                {
                    Node<T> node = new Node<T>(item);
                    Node<T> temp = Head;
                    for (int i = 1; i < pos; i++)
                    {
                        temp = temp.Next;
                    }
                    node.Next = temp.Next;
                    temp.Next = node;
                }
                length++;
            }
        }
        public void AddAfter(T item, int pos)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty..");
            }
            else if (pos >= length || pos < 0)
            {
                Console.WriteLine("Position out of range");
            }
            else
            {
                if (pos == 0)
                    AddFirst(item);
                if (pos == length)
                    AddLast(item);
                else
                {
                    Node<T> node = new Node<T>(item);
                    Node<T> temp = Head;
                    for (int i = 0; i < pos; i++)
                    {
                        temp = temp.Next;
                    }
                    node.Next = temp.Next;
                    temp.Next = node;
                }
                length++;
            }
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                if (length == 1)
                    Head = Tail = null;
                else
                    Head = Head.Next;
                length--;
            }
        }
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                if (length == 1)
                    Head = Tail = null;
                else
                {
                    Node<T> cur = Head;
                    while (cur.Next != Tail)
                    {
                        cur = cur.Next; //at the end it will be equal to the node before the tail
                    }
                    Tail = cur;
                    Tail.Next = null;
                }
                length--;
            }
        }
        public void RemoveElement(T element)
        {
            if (IsEmpty())
                return;

            else
            {
                if (element.Equals(Head.Value))
                {
                    RemoveFirst();
                }
                else if(element.Equals(Tail.Value))
                {
                    RemoveLast();
                }
                else
                {
                    Node<T> curr = Head;
                    Node<T> prev = Head;
                    while (curr.Next != null&&!curr.Value.Equals(element)) 
                    {
                        prev = curr;
                        curr = curr.Next;
                    }
                    prev.Next = curr.Next;
                    if (curr.Next == null)
                    {
                        Tail = prev;
                    }
                    curr.Next = null;
                }
                length--;
            }
        }
        public void RemoveAt(int index)
        {
            if(index < 0 || index >= length)
            {
                Console.WriteLine("index out of range..");
                return;
            }
            else
            {
                if(index == length-1)
                {
                    RemoveLast();
                }
                else if(index == 0)
                {
                    RemoveFirst();
                }
                else
                {
                    Node<T> curr = Head;
                    Node<T> prev = Head;
                    for(int i=0; i<index; i++)
                    {
                        prev = curr; 
                        curr = curr.Next;
                    }
                    prev.Next = curr.Next;
                    if (curr.Next == null)
                    {
                        Tail = prev;
                    }
                    curr.Next = null;
                }
            }
        }
        public void Print()
        {
            Node<T> node = Head;
            while (node != null)
            {
                Console.WriteLine($"{node.Value} ");
                node=node.Next;
            }
        }

    }
}

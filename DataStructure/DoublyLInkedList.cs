using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsAndDataStructures.DataStructure
{
   
    internal class DoublyLInkedList<T>
    {
        private class NodeD<T>
        {
            public T Value;
            public NodeD<T> Next;
            public NodeD<T> Previous;
            public NodeD(T value)
            {
                    Value= value;
            }
            public NodeD()
            {
                
            }
        }
        private int count;
        private NodeD<T> Head;
        private NodeD<T> Tail;
        public DoublyLInkedList()
        {
            Head = null;
            Tail = null;
            count= 0;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public int Count()
        {
            return count;
        }
        public void AddFirst(T element)
        {
            NodeD<T> node=new NodeD<T>(element);
            if(count == 0)
            {
                Head=Tail = node;
            }
            else
            {
                node.Next = Head;
                node.Previous = null;
                Head.Previous = node;
                Head = node;
            }
            count++;
        }
        public void AddLast(T element)
        {
            NodeD<T> node = new NodeD<T>(element);
            if (count == 0)
            {
                Head = Tail = node;
            }
            else
            {
                node.Previous=Tail;
                node.Next=null;
                Tail.Next = node;
                Tail=node;
            }
            count++;
        }
        public void insertAt(int index, T element)
        {
            if(index < 0 || index > count)
            {
                Console.WriteLine("out of range..");
                return;
            }
            else
            {
                if (index == 0)
                    AddFirst(element);
                else if (index == count)
                    AddLast(element);
                else
                {
                    NodeD<T> node = new NodeD<T>(element);
                    NodeD<T> temp = Head.Next;
                    for (int i = 1; i < index-1; i++)
                    {
                        temp = temp.Next;
                    }
                    node.Next = temp.Next;
                    temp.Next.Previous = node;
                    node.Previous = temp;
                    temp.Next = node;
                }
                count++;
            }
        }
        public void RemoveFirst()
        {
            if (count == 0)
            {
                return;
            }
            else
            {
                Head.Next.Previous = null;
                Head = Head.Next;
            }
        }
        public void RemoveLast()
        {
            if (count == 0)
            {
                return;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
        }
        public void Display()
        {
            if(count == 0)
            {
                return;
            }
            else if(count == 1) 
            {
                Console.WriteLine(Head.Value);
            }
            else
            {
                NodeD<T> temp = Head;
                while(temp != null)
                {
                    Console.WriteLine(temp.Value);
                    temp = temp.Next;
                }
            }
        }
        public void reverseDisplay()
        {
            if (count == 0)
            {
                return;
            }
            else if (count == 1)
            {
                Console.WriteLine(Head.Value);
            }
            else
            {
                NodeD<T> temp = Tail;
                while (temp != null)
                {
                    Console.WriteLine(temp.Value);
                    temp = temp.Previous;
                }
            }
        }
    }
}

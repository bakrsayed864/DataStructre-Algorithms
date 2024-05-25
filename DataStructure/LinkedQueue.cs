using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructure
{
    internal class LinkedQueue<T>
    {
        private int count;
        private Node<T> front;
        private Node<T> back;

        public LinkedQueue()
        {
            count = 0;
            front = new Node<T>();
            back = new Node<T>();
        }

        public bool isEmpty()
        {
            return count == 0;
        }
        public int GetSize()
        {
            return count;
        }
        public void Enqueue(T item)
        {
            Node<T> node=new Node<T>(item);
            if(count == 0)
            {
                front = back = node;
            }
            else
            {
                back.Next= node;
                back=node;
            }
            count++;
        }

        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty..");
                return;
            }
            else
            {
                front = front.Next;
                count--;
            }
        }

        public T GetFront()
        {
            if(!isEmpty())
                return front.Value;
            else
                throw new InvalidOperationException();
        }
         public T GetBack()
        {
            if (!isEmpty())
                return back.Value; 
            else
                throw new InvalidOperationException();

        }
    }
}

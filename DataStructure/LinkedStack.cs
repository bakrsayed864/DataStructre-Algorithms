using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructure
{
    internal class LinkedStack<T>
    {
        private Node<T> Top { get; set; } = null;
        private int Size { get; set; } = 0;

        public void Push(T newItem)
        {
            Node<T> node = new Node<T>();
            node.Value = newItem;
            if (Size == 0)
            {
                Top = node;
                Size++;
            }
            else
            {
                node.Next = Top;
                Top=node;
                Size++;
            }
        }
        public void Pop()
        {
            if (Size == 0) 
            {
                Console.WriteLine("Your Stack is empty");
                return;
            }
            else
            {
                Node<T> temp = Top;
                Top = Top.Next;
                temp = null;
                Size--;
            }
        }
        public void Display() 
        {
            Node<T> curr= Top;
            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Next;
            }
        }
        public int getSize()
        {
            return Size;
        }
        public bool isEmpty()
        {
            return Top == null;
        }
    }
}

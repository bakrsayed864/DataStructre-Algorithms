using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructure
{
    internal class CustomeArrayList<T>
    {
        private int length;
        private T[] array;
        private int MaxSize;
        public CustomeArrayList(int Size)
        {
            if (Size <= 0)
                MaxSize = 10;
            else
                MaxSize = Size;
            array = new T[Size];
            length = 0;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
        public bool IsFull()
        {
            return length == MaxSize;
        }
        public int getSize()
        {
            return length;
        }
        public void Print()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
        }
        public void insertAt(int pos, T element)
        {
            if (IsFull())
            {
                Console.WriteLine("ArrayList is full..");
            }
            else if (pos < 0 || pos >= length)
            {
                Console.WriteLine("Out of range of insertion..");
            }
            else
            {
                for (int i = length; i > pos; i--)
                {
                    array[i] = array[i - 1];
                }
                array[pos] = element;
                length++;
            }
        }
        public void removeAt(int pos)
        {
            if (IsEmpty())
            {
                Console.WriteLine("ArrayList is empty");
            }
            else if (pos < 0 || pos >= length)
            {
                Console.WriteLine("Out of range of deletion..");
            }
            else
            {
                for(int i = pos; i < length; i++)
                {
                    array[i] = array[i+1];
                }
            }
        }
        public void Append(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("ArrayList is full..");
            }
            else
            {
                array[length] = element;
                length++;
            }
        }
        public int Search(T element)
        {
            if (!IsEmpty())
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i].Equals(element))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public void Update(int pos, T element)
        {
            if (IsEmpty())
            {
                Console.WriteLine("ArrayList is empty..");
            }
            else if(pos < 0 || pos >= length)
            {
                Console.WriteLine("position is out of range of elements..");
            }
            else
            {
                array[pos] = element;
            }
        }
        public T GetElement(int pos)
        {
            if (pos < 0 || pos >= length)
            {
                Console.WriteLine("position is out of range of elements..");
                throw new ArgumentOutOfRangeException();
            }
            else { return array[pos]; }

        }
    }
}

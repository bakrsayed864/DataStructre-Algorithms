using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructure
{
    internal class CustomQueue<T>
    {
        private int front;
        private int back;
        private int size=0;
        private T[] array;
        private int ArrSize;
        public CustomQueue(int arrSize)
        {
            front = 0;
            back = arrSize - 1;
            if (arrSize <= 0)
            {
                ArrSize = 10;
            }
            else
                ArrSize = arrSize;
            array = new T[ArrSize];
        }
        public bool IsFull()
        {
            return size == ArrSize;
        }
        public bool IsEmpty() 
        {
            return size == 0;
        }
        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full, cannot add this item...");
            }
            else
            {
                back = (back + 1) % ArrSize;
                array[back] = item;
                size++;
            }
        }
        public void Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is already empty..");
            }
            else
            {
                front=(front+1)%ArrSize;
                size--;
            }
        } 
        public void Display()
        {
            for (int i=front;i!=back; i = (i + 1) % ArrSize)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(array[back]);
        }
    }
}

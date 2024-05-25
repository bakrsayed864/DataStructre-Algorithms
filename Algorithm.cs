using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class Algorithm
    {
        /// <summary>
        /// /
        /// </summary>
        /// <param name="list">unsorted List</param>
        /// <returns>sorted list</returns>
        /// // complexity O(N^2)
        public static List<int> BubbleSort(List<int> list)
        {
            int keep;
            bool swapped; //for more performance (if specific iteration does not make any swaping i should stop iteration)
            for(int i=0;i<list.Count-1; i++)
            {
                swapped = false;
                for(int j = 0; j < list.Count-i-1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        keep = list[j];
                        list[j]= list[j + 1];
                        list[j+1]= keep;
                    }
                    swapped = true;
                }
            }
            return list;
        }
        // complexity O(N^2)
        public static List<int> SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                int minIndex = i;
                for(int j=i+1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //this make more operations cause of shifting hapening after removing and inserting
                //int keep = list[minIndex];
                //list.RemoveAt(minIndex);
                //list.Insert(i, keep);
                //this for more efficient
                int keep = list[i];
                list[i]= list[minIndex];
                list[minIndex]= keep;
            }
            return list;
        }
        
    }
}

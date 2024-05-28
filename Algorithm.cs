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
                        //swap
                        keep = list[j];
                        list[j]= list[j + 1];
                        list[j+1]= keep;
                    }
                    swapped = true;
                }
            }
            return list;
        }
        /// <summary>
        /// /select min element and put it in first, and iterate until sorting the array
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> InsertionSort(List<int> list)
        {

            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j= i-1;
                for ( ;j >= 0 ; j--)
                {
                    if (list[j] > key)
                    {
                        list[j+1] = list[j];
                    }
                    else
                        break;
                }
                list[j+1] = key;
            }
            return list;
        }
        
        public static void mergeSort(List<int> list)
        {
            if (list == null || list.Count <= 1)
            {
                return;
            }
            mergeSort(list,0,list.Count-1);
        }
        private static void mergeSort(List<int> list,int l,int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                mergeSort(list,l,m);
                mergeSort(list,m+1,r);

                merge(list,l,m,r);
            }
        }
        private static void merge(List<int> list,int l,int m,int r)
        {
            // Create the left and right sublists
            List<int> left = list.GetRange(l, m - l + 1);
            List<int> right = list.GetRange(m + 1, r - m);

            // Now left and right contain the respective parts of the original list
            // You can proceed with your merge logic here

            int i = 0, j = 0, k = l;

            // Merge the left and right lists back into the original list
            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    list[k] = left[i];
                    i++;
                }
                else
                {
                    list[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy any remaining elements from left
            while (i < left.Count)
            {
                list[k] = left[i];
                i++;
                k++;
            }

            // Copy any remaining elements from right
            while (j < right.Count)
            {
                list[k] = right[j];
                j++;
                k++;
            }

        }
    }
}

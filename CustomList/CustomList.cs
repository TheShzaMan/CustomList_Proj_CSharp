using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Capacity { get => capacity; }
        public int Count { get => count; }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the range of this array.");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the range of this array.");
                }
                items[index] = value;
            }
        }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }
        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else  
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[count] = item;
                count++;
                items = newItems;
            }
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

            bool itemRemoved = false;
            if (items.Contains(item))
            {
                T[] newArray = new T[capacity];
                for (int i = 0, j = 0; i < count; i++, j++)
                {
                    newArray[j] = this[i];
                    if (i == j)
                    {
                        if (this[i].Equals(item))
                        {
                            j--;
                        }
                    }
                }
                items = newArray;
                count--;
                itemRemoved = true; 
            }
            return itemRemoved;  
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            string[] itemsAsStrings = new string[count];
            for (int i = 0; i < count; i++)
            {
                itemsAsStrings[i] = Convert.ToString(this[i]);
            }
            string listAsString = string.Join(" ", itemsAsStrings);
            return listAsString;
        }

    public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < count; ++i)
            {
                yield return this[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            CustomList<T> combinedLists = new CustomList<T>();

            for (int i = 0; i < (firstList.Count); i++)
            {
                combinedLists.Add(firstList[i]);
            }
            for (int i = 0; i < (secondList.Count); i++)
            {
                combinedLists.Add(secondList[i]);
            }
            //CustomList<T> allItems = firstList.items + secondList.items;
            return combinedLists;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            CustomList<T> combinedList = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].Equals(secondList[j]))
                    {
                        firstList.Remove(firstList[i]);
                        secondList.Remove(secondList[j]);
                        i--;
                        break;
                    }
                }
            }
            return firstList;
        }
        public void Zip(CustomList<T> listToZip)
        {
            T[] zippedList = new T[count + listToZip.count];
            for (int i = 0, j = 0; j < (count + listToZip.count); i++, j += 2)
            {
                zippedList[j] = this[i];
                zippedList[j + 1] = listToZip[i];
            }
            count += (count + listToZip.count) / 2;
            items = zippedList;

        }
    }
}

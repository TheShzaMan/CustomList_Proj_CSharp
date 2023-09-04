using System.Collections;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomList<bool> myList = new CustomList<bool>();
            //myList.Add("a");
            //myList.Add("b");
            //myList.Add("c");
            //myList.Add("d");
            //myList.Add("e");
            //myList.Add(true);
            //myList.Add(true);
            //myList.Add(false);
            //myList.Add(true);
            //myList.Add(false);

            //string myListAsString = myList.ToString();
            //Console.WriteLine(myListAsString);
            //CustomList<int> intList = new CustomList<int>();
            //CustomList<int> intList2 = new CustomList<int>() { 6, 7, 8, 9, 10 };
            //intList.Add(1);
            //intList.Add(2);
            //intList.Add(3);
            //intList.Add(4);
            //intList.Add(5);

            //CustomList<int> comboList = intList + intList2;

            CustomList<string> firstList = new CustomList<string>() { "a", "b", "c", "a", "b" };
            CustomList<string> secondList = new CustomList<string>() { "b", "c", "a", };

            // Act
             CustomList<string> newList = firstList - secondList;
            //string newStringFromList = newList.ToString();

            //Console.WriteLine(newStringFromList);
            //Console.WriteLine("\n---------------------\n");
            Console.WriteLine(newList);
        }
    }
}
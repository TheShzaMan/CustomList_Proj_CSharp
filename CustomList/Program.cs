using System.Collections;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<bool> myList = new CustomList<bool>();
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
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);


            // Act
            string newStringFromInts = intList.ToString();
        }
    }
}
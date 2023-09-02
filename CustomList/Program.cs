using System.Collections;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c_Count = 0;
            CustomList<string> customList = new CustomList<string> { "A","B","C","C","C","D","E" };

            customList.Remove("C");

            foreach (string item in customList)
            {
                if (item == "C")
                {
                    c_Count++;
                }
            }
            Console.WriteLine(c_Count);
        }
    }
}
namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("A");
            customList.Add("B");
            customList.Add("C");
            customList.Add("D");
            customList.Add("E");
            Console.WriteLine(customList.Items[4]);
        }
    }
}
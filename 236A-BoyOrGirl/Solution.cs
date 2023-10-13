namespace BoyorGirl
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int CountOfDistinct = Console.ReadLine().Distinct().Count();
            Console.WriteLine(CountOfDistinct % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");
        }
    }
}
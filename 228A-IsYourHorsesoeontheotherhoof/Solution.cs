namespace IsYourHorsesoeontheotherhoof
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int result = 0;
            Dictionary<string, int> map = new();
            string[] input = Console.ReadLine().Trim().Split(' ').ToArray();
            foreach (string val in input)            
                if (!map.TryAdd(val, 1))
                    map[val]++;
            foreach (string val in map.Keys)
                if (map[val] > 1)
                    result += map[val] - 1;
            Console.WriteLine(result);

        }
    }
}
using System.Text;

namespace StringTask
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] {'a','o','y','e','u','i' };
            string input = Console.ReadLine().ToLower();
            StringBuilder sb = new();
            for(int i=0;i<input.Length;i++)
            {
                if (!vowels.Contains(input[i]))
                {
                    sb.Append(".");
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
            
        }
        
    }
}
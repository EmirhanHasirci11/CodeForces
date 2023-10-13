namespace Team
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int result = 0;
            int countOfSolution = Convert.ToInt32(Console.ReadLine());            
            for(int i=0;i<countOfSolution;i++)
            {
               
                int votesSum=Console.ReadLine().Trim().Split(' ').Select(x=>int.Parse(x)).Sum();
                if (votesSum >= 2)
                    result++;

            }
            Console.WriteLine(result);

        }
    }
}
using System;
using System.Linq;
class CandidateCode
{
    static void Main(string[] args)
    {

        int noOfPackets = Int32.Parse(System.Console.ReadLine().Trim());
        long[] noOfBalls = System.Console.ReadLine().Split().Select(long.Parse).ToArray();
        long totalMoves = 0;
        for (int i = 0; i <= noOfPackets - 1; i++)
        {
            totalMoves += FindGroups(noOfBalls[i]);
        }
        Console.WriteLine(totalMoves);
    }

    static long FindGroups(long balls)
    {
        long count = balls;
        while (balls != 1)
        {
            var quot = balls / FindSmallestFactor(balls);
            count += quot;
            balls = quot;
        }
        return count;
    }

    static long FindSmallestFactor(long n)
    {
        if (n % 2 == 0)
        {
            return 2;
        }
        for (long i = 3; i <= (long) Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                return i;
            }
        }
        return n;
    }

}

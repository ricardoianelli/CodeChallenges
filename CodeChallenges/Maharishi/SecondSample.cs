using System;

namespace CodeChallenges.Maharishi
{
    public class SecondSample
    {
        public static int DifferenceOfSums(int[] inputArray)
        {
            if (inputArray is null)
                return 0;

            var sum = 0;

            foreach (var number in inputArray)
            {
                if (number % 2 == 0)
                    sum -= number;
                else
                    sum += number;
            }

            return sum;
        }
    }
}
using System;

namespace CodeChallenges.Maharishi
{
    public class SixthSample
    {
        public static int GetPointOfEquilibrium(int[] array)
        {
            if (array == null || array.Length < 3)
                return -1;

            var rightSum = 0;
            var leftSum = 0;

            for (int l = 1; l < array.Length; l++)
            {
                leftSum += array[l-1];
                for (int r = array.Length-1; r > l; r--)
                {
                    rightSum += array[r];
                }

                if (leftSum > rightSum)
                    break; 
                if (leftSum == rightSum)
                    return l;
                
                rightSum = 0;
            }

            return -1;
        }
    }
}
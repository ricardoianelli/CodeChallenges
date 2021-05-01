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

            var leftIndex = 0;
            var rightIndex = array.Length - 1;

            var pointOfEq = -1;

            while (leftIndex < rightIndex)
            {
                if (leftSum > rightSum)
                {
                    rightSum += array[rightIndex];
                    rightIndex--;
                }
                else
                {
                    leftSum += array[leftIndex];
                    leftIndex++;
                }
            }

            if (leftSum == rightSum)
                pointOfEq = leftIndex;
            
            return pointOfEq;
        }
    }
}
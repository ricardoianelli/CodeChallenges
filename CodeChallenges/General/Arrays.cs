using System;

namespace CodeChallenges.General
{
    public static class Arrays
    {
        public static int[] ReverseArray(int[] inputArray)
        {
            if (inputArray is null || inputArray.Length < 2)
                return inputArray;
            
            int lastPickedValue;
            int oppositeIndex;
            var lastIndex = inputArray.Length - 1;
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                lastPickedValue = inputArray[i];
                oppositeIndex = lastIndex - i;
                inputArray[i] = inputArray[oppositeIndex];
                inputArray[oppositeIndex] = lastPickedValue;
            }

            return inputArray;
        }
    }
}
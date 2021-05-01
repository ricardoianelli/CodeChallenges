using System;

namespace CodeChallenges.Maharishi
{
    public class FifthSample
    {
        public static int[] InnerJoin(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null || secondArray == null)
                return null;
            
            if (firstArray.Length == 0 || secondArray.Length == 0)
                return new int[0];
            
            var smallerArray = firstArray;
            var biggerArray = secondArray;
            
            if (firstArray.Length > secondArray.Length)
            {
                smallerArray = secondArray; 
                biggerArray = firstArray;
            }

            var found = 0;
            var matches = new int[smallerArray.Length];
            for (int i = 0; i < smallerArray.Length; i++)
            {
                for (int j = 0; j < biggerArray.Length; j++)
                {
                    if (smallerArray[i] == biggerArray[j])
                    {
                        matches[found++] = smallerArray[i];
                    }
                }
            }

            var finalResult = new int[found];
            for (int i = 0; i < found; i++)
            {
                finalResult[i] = matches[i];
            }

            return finalResult;
        }
    }
}
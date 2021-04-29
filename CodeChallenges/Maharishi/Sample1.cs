namespace CodeChallenges.Maharishi
{
    public class MaharishiSample1
    {
        public static int IsACenteredArray(int[] sampleArray)
        {
            var lenght = sampleArray?.Length;
            if (lenght is null || lenght % 2 == 0)
            {
                return 0;
            }
            
            var middleIndex = sampleArray.Length/2;
            var middleValue = sampleArray[middleIndex];

            for (var i = 0; i < lenght; i++)
            {
                if (sampleArray[i] <= middleValue && i != middleIndex)
                    return 0;
            }

            return 1;
        }
    }
}
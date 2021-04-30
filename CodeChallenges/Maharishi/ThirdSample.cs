using System;

namespace CodeChallenges.Maharishi
{
    public class ThirdSample
    {
        public static char[] GetCharsFromArray(char[] charArray, int startIndex, int charsToTake)
        {
            var outputLenght = startIndex + charsToTake;
            if (charArray is null || startIndex < 0 || charsToTake < 0 || outputLenght > charArray.Length)
                return null;

            var newArray = new char[charsToTake];
            for (int i = startIndex; i < outputLenght; i++)
                newArray[i - startIndex] = charArray[i];

            return newArray;
        }
    }
}
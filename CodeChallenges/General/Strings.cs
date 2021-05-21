namespace CodeChallenges.General
{
    public class Strings
    {
        public static int CountCharAppearance(string stringToSearch, char charToLookUp)
        {
            if (stringToSearch is null)
                return 0;

            var count = 0;
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                if (stringToSearch[i] == charToLookUp)
                    count++;
            }
            return count;
        }
    }
}
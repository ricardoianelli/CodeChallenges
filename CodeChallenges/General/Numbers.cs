namespace CodeChallenges.General
{
    public static class Numbers
    {
        public static int RaiseNumber(int n, int power)
        {
            switch (n)
            {
                case 1:
                    return 1;
                case <= 0:
                    return 0;
            }

            var result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}
namespace CodeChallenges.General
{
    public static class Numbers
    {
        public static double RaiseNumber(double n, int power)
        {
            double result = 1;

            if (n == 0 || n == 1)
                return n;

            if (power < 0)
            {
                n = 1 / n;
                power *= -1;
            }
                
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}
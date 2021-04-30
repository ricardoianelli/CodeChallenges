using System;

namespace CodeChallenges.Maharishi
{
    public class FourthSample
    {
        public static int ReverseNumber(int number)
        {
            if (number == 0)
                return 0;
            
            var negativeNumber = number < 0;
            if (negativeNumber)
                number *= -1;
            
            var outputNumber = 0;
            var powerOfTen = (int) Math.Log10(number);

            do
            {
                var rightmostNumber = number % 10;
                var currentBase = (int) Math.Pow(10, powerOfTen);
                var currentPart = rightmostNumber * currentBase;

                outputNumber += currentPart;
                number /= 10;
                powerOfTen--;
            } 
            while (powerOfTen > 0);

            outputNumber += number;

            if (negativeNumber)
                outputNumber *= -1;
            
            return outputNumber;
        }
    }
}
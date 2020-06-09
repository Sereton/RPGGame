using System;
using System.Security.Cryptography;


namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int NumberInBetween(int minValue, int maxValue)
        {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);

           return (int)(minValue+Math.Floor((maxValue - minValue + 1) * ((float)randomNumber[0] / 255f)));

        }

    }
}

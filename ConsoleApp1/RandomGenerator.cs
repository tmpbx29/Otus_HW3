using SOLID.Interfaces;
using System;

namespace SOLID
{
    public class RandomGenerator : IRandomGenerator
    {
        public int GetNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue + 1);
        }
    }
}

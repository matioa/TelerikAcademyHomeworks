using System;

namespace Abstraction
{
    internal class Validator
    {
        internal static void ValidateIfPositive(double value, string valueName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(valueName + " cannot be negative or equal to 0.");
            }
        }
    }
}
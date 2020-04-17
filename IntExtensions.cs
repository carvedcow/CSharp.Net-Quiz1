using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Net_Quiz1
{
    public static class IntExtensions
    {
        public static bool IsDividableBy(this int i, int j)
        {
            bool result = false;
            if (i % j == 0)
            {
                result = true;
            }
            return result;
        }
    }
}

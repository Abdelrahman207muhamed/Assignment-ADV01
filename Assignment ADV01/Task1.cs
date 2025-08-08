using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV01
{
    internal class Task1
    {
        public class RipenessChecker<T> where T : IComparable<T>
        {
            private T lowLimit;
            private T highLimit;

            // Constructor
            public RipenessChecker(T low, T high)
            {
                lowLimit = low;
                highLimit = high;
            }

            // Method with a different name
            public bool CheckRipeness(T level)
            {
                bool aboveMin = level.CompareTo(lowLimit) >= 0;
                bool belowMax = level.CompareTo(highLimit) <= 0;
                return aboveMin && belowMax;
            }
        }

    }
}

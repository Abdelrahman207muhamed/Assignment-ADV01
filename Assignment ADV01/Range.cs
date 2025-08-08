using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV01
{
    public class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;

        public Range(T min, T max)
        {
            
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Minimum value must be less than or equal to Maximum value.");

            this.min = min;
            this.max = max;
        }

        
        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        
        public double Length()
        {
            
            double minVal = Convert.ToDouble(min);
            double maxVal = Convert.ToDouble(max);
            return maxVal - minVal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV01
{
    internal class NumberFilter
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0) 
                {
                    evenNumbers.Add(num);
                }
            }

            return evenNumbers;
        }

    }
}

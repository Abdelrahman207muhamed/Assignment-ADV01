using System.Collections;
using static Assignment_ADV01.Task1;

namespace Assignment_ADV01
{
    internal class Program
    {
        static void Main()
        {
            #region TASK 1
            //Console.WriteLine("=== Banana Ripeness Checker ===");

            //// Get range limits
            //Console.Write("Minimum perfect ripeness: ");
            //var minVal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Maximum perfect ripeness: ");
            //var maxVal = Convert.ToDouble(Console.ReadLine());

            //// Create checker object
            //var checker = new RipenessChecker<double>(minVal, maxVal);

            //// Get ripeness to test
            //Console.Write("Enter ripeness to test: ");
            //var testVal = Convert.ToDouble(Console.ReadLine());

            //// Show result
            //string result = checker.CheckRipeness(testVal) ? "Perfect Banana!" : "Not Perfect!";
            //Console.WriteLine(result);
            #endregion

            #region Task2

            MultiBox<string> stringBox = new MultiBox<string>();

            Console.WriteLine(stringBox.IsEmpty()); // True

            stringBox.InsertItem("Book");
            stringBox.InsertItem("Laptop");

            Console.WriteLine(stringBox.Count()); // 2

            foreach (var item in stringBox.GetAllItems())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stringBox.IsEmpty()); // False



            #endregion


            #region Q1
            Range<int> intRange = new Range<int>(10, 20);

            Console.WriteLine(intRange.IsInRange(15)); // True
            Console.WriteLine(intRange.IsInRange(25)); // False

            Console.WriteLine("Length: " + intRange.Length()); // 10

            Range<double> doubleRange = new Range<double>(5.5, 10.5);
            Console.WriteLine(doubleRange.IsInRange(7.5)); // True
            Console.WriteLine("Length: " + doubleRange.Length()); // 5.0 
            #endregion

            #region Q2
            ArrayList myList = new ArrayList() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before Reverse:");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

            ArrayListHelper.ReverseArrayList(myList);

            Console.WriteLine("\nAfter Reverse:");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            } 
            #endregion

        }

    }
} 
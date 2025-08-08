using System.Collections;
using static Assignment_ADV01.Task1;

namespace Assignment_ADV01
{
    internal class Program
    {


        #region Q2
        // Method to reverse ArrayList elements in place
        static void ReverseList(ArrayList arr)
        {
            for (int i = 0; i < arr.Count / 2; i++)
            {
                int j = arr.Count - 1 - i;
                (arr[i], arr[j]) = (arr[j], arr[i]); // tuple swap
            }
        }
        #endregion

        #region Q3
        static IEnumerable<int> FilterEvens(IEnumerable<int> data)
        {
            return data.Where(x => x % 2 == 0);
        } 
        #endregion


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
            ArrayList items = new ArrayList();

            Console.Write("How many items? ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine("Enter your items:");
            for (int k = 0; k < n; k++)
                items.Add(Console.ReadLine());

            Console.WriteLine("\nBefore reverse:");
            foreach (var el in items)
                Console.Write(el + " ");
            Console.WriteLine();

            ReverseList(items);

            Console.WriteLine("\nAfter reverse:");
            foreach (var el in items)
                Console.Write(el + " ");
            Console.WriteLine();

            ReverseList(items);

            Console.WriteLine("\nAfter reverse:");
            foreach (var el in items)
                Console.Write(el + " ");
            Console.WriteLine();

            #endregion

            #region Q3
            Console.Write("How many numbers? ");
            if (!int.TryParse(Console.ReadLine(), out int total) || total <= 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            var inputList = new List<int>();

            Console.WriteLine("Enter numbers:");
            for (int idx = 0; idx < total; idx++)
            {
                if (int.TryParse(Console.ReadLine(), out int val))
                    inputList.Add(val);
            }

            var evens = FilterEvens(inputList);

            Console.WriteLine("\nEvens found:");
            Console.WriteLine(string.Join(" ", evens));
        }
        #endregion


    }

    
} 
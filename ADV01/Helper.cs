using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Helper
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            bool swapped;
            int newN;

            do
            {
                swapped = false;
                newN = 0;

                for (int i = 1; i < n; i++)
                {
                    if (arr[i - 1].CompareTo(arr[i]) > 0)
                    {
                        T temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;

                        swapped = true;
                        newN = i;
                    }
                }
                n = newN;

            } while (swapped);
        }


        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
        

    }
}

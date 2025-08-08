using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Helper<T>  where T : IComparable<T>
    {
        

        
        public static void SWAP(ref object X, ref object Y)
        {
            Console.WriteLine("After Swap");
            object temp = X;
            X = Y;
            Y = temp;
        }
        public static void SWAP(ref double X, ref double Y)
        {
            Console.WriteLine("After Swap");
            double temp = X;
            X = Y;
            Y = temp;
        }

        public static void SWAP(ref Point X, ref Point Y)
        {
            Console.WriteLine("After Swap");
            Point temp = X;
            X = Y;
            Y = temp;
        }
      

        
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
     

        public static int searchArray(T[] Array, T Value)
        {
            if (Array is not null)
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Equals(Value))
                        return i;
                }
            }
            return -1;
        }



        public static void BubbleSort(T[] Array)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - i - 1; j++)
                    {
                        
                        if (Array[j].CompareTo(Array[j + 1]) == 1)
                            Helper<int>.SWAP(ref Array[j], ref Array[j + 1]);
                    }
                }
            }
        }
    }
}

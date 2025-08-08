namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q01
            /* 01 */
            //int[] Numbers = { 3, 5, 2 ,9 , 4 , 7 ,6 };
            //Helper.Sort (Numbers);
            //foreach (int i in Numbers) { Console.WriteLine(i); } 
            #endregion

            #region Q02
            /* 02 */
            //var intRange = new Range<int>(1, 10);
            //Console.WriteLine(intRange.IsInRange(5));  
            //Console.WriteLine(intRange.IsInRange(15)); 
            //Console.WriteLine(intRange.Length());


            //var doubleRange = new Range<double>(1.5, 5.5);
            //Console.WriteLine(doubleRange.IsInRange(3.2)); 
            //Console.WriteLine(doubleRange.Length());       
            #endregion

            #region Q03
            /* 03 */
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            //ArrayListReverser.Reverse(list);

            //foreach (int i in list) {
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Q04
            /* 04 */
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers2 = Helper.GetEvenNumbers(numbers);

            //foreach (int i in evenNumbers2) { Console.WriteLine(i); } 
            #endregion

            #region Q05
            /* 05 */

            //var list = new FixedSizeList<string>(5);

            //list.Add("Ahmed");
            //list.Add("Yasso");
            //list.Add("Nada");


            //try
            //{
            //    list.Add("Maha");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(1));

            //try
            //{
            //    Console.WriteLine(list.Get(4));
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion


        }
    }

}


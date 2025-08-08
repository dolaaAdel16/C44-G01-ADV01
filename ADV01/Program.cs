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
https://github.com/dolaaAdel16/C44-G01-ADV01/pull/3/conflict?name=ADV01%252FProgram.cs&ancestor_oid=d7bd314332c00a1c64a9906dc871acd06b19f7d2&base_oid=c394e266886782aea5ab21309f807f053ec43773&head_oid=50fb50160be8a42e78cc00b7dabf0f95a8c4e18a

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

            #region Befor Generics
            //object A = 3, B = 5; //Boxing
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //-------------------------------
            //object A = 3.2, B = 5.5; //Boxing
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //-------------------------------
            //object p1 = new Point(1, 2);
            //object p2 = new Point(2, 3);
            //Console.WriteLine($"p1={p1}");
            //Console.WriteLine($"p2={p2}");
            //Helper.SWAP(ref p2, ref p2);
            //Console.WriteLine($"p1={p1}");
            //Console.WriteLine($"p2={p2}");
            #endregion

            #region After Generics
            #region  Example SWAp
            //int A = 3, B = 5; 
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //Helper.SWAP<int>(ref A, ref B);
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //----------------------------
            //double A = 3.2, B = 5.5;  
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            //Helper.SWAP<double>(ref A, ref B);
            //Console.WriteLine($"A={A}");
            //Console.WriteLine($"B={B}");
            ////-------------------------------
            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(2, 3);
            //Console.WriteLine($"p1={p1}");
            //Console.WriteLine($"p2={p2}");
            //Helper.SWAP<Point>(ref p2, ref p2);
            //Console.WriteLine($"p1={p1}");
            //Console.WriteLine($"p2={p2}");
            #endregion

            #region  Example Search 
            //int[] Number = { 5, 4, 9, 14, 15, 12, };
            //int Position = Helper.SearchArray(Number, 14);
            //Console.WriteLine($"Position of value = {Position}");
            //-------------------------------------------
            //Employee employee01 = new Employee( 10 ,"Rana",6000);
            //Employee employee02 = new Employee(10, "Rokia", 6000);
            //Employee employee03 = new Employee(10, "Rana", 6000);

            //Employee[] employees =
            //{
            //    employee01,employee02,employee03
            //};
            //int Position = Helper<Employee>.searchArray(employees, new Employee(30, "Ahmed", 8000));
            //Console.WriteLine(Position);


            #endregion

            #region Bubble Sort 
            //int[] Number = { 7, 1, 2, 4, 5, 6 };
            //Helper<int>.BubbleSort(Number);
            //foreach (int number in Number)
            //{
            //    Console.WriteLine(number);
            //}


            //Employee employee01 = new Employee(10, "Rana", 6000);
            //Employee employee02 = new Employee(20, "Rokia", 2000);
            //Employee employee03 = new Employee(300, "Rana", 8000);

            //Employee[] employees =
            //{
            //    employee01,employee02,employee03
            //};
            //Helper<Employee>.BubbleSort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            #region Icomarable Vs Icombarable Generics

            //Point[] points =
            //{
            //    new Point(3,5),
            //    new Point(4,5),
            //    new Point(5,6),
            //    new Point(6,7),


            //};

            //Employee employee01 = new Employee(10, "Rana", 6000);
            //Employee employee02 = new Employee(20, "Rokia", 2000);
            //Employee employee03 = new Employee(300, "Rana", 8000);

            //Employee[] employees =
            //{
            //    employee01,employee02,employee03
            //};

            //Helper<Point>.BubbleSort(points);
            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //}
            //Helper<Employee>.BubbleSort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion


            #endregion

            #region Value Base Equlity Vs Reference Base Equlity(Class) and GetHashCode
            //Employee employee01 =new Employee(20,"Rana",5000);
            //Employee employee02 = new Employee(20, "Rana", 5000);
            //Console.WriteLine($"Employee01.GetHashCode(): {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee02.GetHashCode(): {employee02.GetHashCode()}");

            ////if (employee01 == employee02)
            //if  (employee01.Equals (employee02))
            //{
            //    Console.WriteLine("Employee01 Equle Employee02");
            //}
            //else 
            //{
            //    Console.WriteLine("Empolyee01 !Equle Employee02");

            //}

            #endregion



        }
    }

}


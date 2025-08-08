namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


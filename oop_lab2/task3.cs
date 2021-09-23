//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oop_lab2
//{
//    class task3
//    {
//        static void Main()
//        {
//            int[,] arrint = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
//            for (int i = 0; i < arrint.GetLength(0); i++)
//            {
//                for (int j = 0; j < arrint.GetLength(1); j++)
//                {
//                    Console.Write(arrint[i, j]);
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            string[] arrstr = { "first", "second", "third" };
//            foreach (string a in arrstr)
//            {
//                Console.WriteLine(a);
//            }
//            Console.WriteLine(arrstr.GetLength(0));
//            arrstr[0] = "one";
//            foreach (string a in arrstr)
//            {
//                Console.WriteLine(a);
//            }
//            Console.WriteLine();

//            int[][] arr1 = new int[3][];
//            arr1[0] = new int[2];
//            arr1[1] = new int[3];
//            arr1[2] = new int[4];

//            for (int q = 0; q < arr1.GetLength(0); q++)
//            {
//                for (int w = 0; w < arr1[q].GetLength(0); w++)
//                {
//                    arr1[q][w] = Convert.ToInt32(Console.ReadLine());
//                }
//                Console.WriteLine();
//            }

//            for (int q = 0; q < arr1.GetLength(0); q++)
//            {
//                for (int w = 0; w < arr1[q].GetLength(0); w++)
//                {
//                    Console.Write($"{arr1[q][w]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            var arr2 = new[] { 1, 2, 3 };
//            foreach (int x in arr2)
//            {
//                Console.Write(x + " ");
//            }

//            var str = "hello";
//            Console.WriteLine(str);

//            Console.ReadKey();
//        }
//    }
//}

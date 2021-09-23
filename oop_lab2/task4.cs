//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oop_lab2
//{
//    class task4
//    {
//        static void Main()
//        {
//            (int nt, string str1, char ch, string str2, ulong ulng) cort = (-2, "КТО", 'Q', "ДВЕРЬ", 1000000);
//            Console.WriteLine($"Это кортеж:{cort.nt} {cort.str1} {cort.ch} {cort.str2} {cort.ulng}");
//            Console.WriteLine($"Выборочно:{cort.Item1} {cort.Item3} {cort.Item4}");
//            var (one, two, three, four, five) = cort;
//            string str3 = cort.str2;
//            Console.WriteLine($"Распоковочка:{one}, {two}, {three}, {four}, {five}, {str3}");
//            int diff1 = (5, 4).CompareTo((4, 5)); 
//            int diff2 = (5, 4).CompareTo((5, 4)); 
//            int diff3 = (4, 5).CompareTo((5, 4));
//            Console.WriteLine($"{diff1} {diff2} {diff3}");

//            Console.ReadKey();
//        }
//    }
//}

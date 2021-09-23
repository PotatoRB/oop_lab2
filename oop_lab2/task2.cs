//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oop_lab2
//{
//    class task2
//    {
//        static void Main()
//        {
//            string first = "that`s first string ";
//            string second = "that`s second string ";
//            string third = "that`s third string ";
//            Console.WriteLine(first);
//            Console.WriteLine(second);
//            Console.WriteLine(third);

//            string cnct = String.Concat(first, second, third);
//            Console.WriteLine(cnct);
//            string cp = String.Copy(first);
//            Console.WriteLine(cp);
//            string sbstrng = second.Substring(2, 7);
//            Console.WriteLine(sbstrng);
//            string[] splt = third.Split();
//            foreach (string ww in splt)
//            {
//                Console.WriteLine(ww);
//            }
//            string nsrt = first.Insert(7, second);
//            Console.WriteLine(nsrt);
//            string rmv = third.Remove(0, 7);
//            Console.WriteLine(rmv);
//            Console.WriteLine($"{first}, {second}, {third}");

//            string nul0 = "";
//            if (String.IsNullOrEmpty(nul0))
//                Console.WriteLine("nul0 пусто");
//            else
//                Console.WriteLine("nul0 не пусто");
//            string nul1 = null;
//            if (String.IsNullOrEmpty(nul1))
//                Console.WriteLine("nul1 пусто");
//            else
//                Console.WriteLine("nul1 не пусто");

//            StringBuilder sb = new StringBuilder("StringBuilder", 60);
//            Console.WriteLine(sb);
//            sb.Remove(0, 6);
//            sb.Insert(0, "?");
//            sb.Append("?");
//            Console.WriteLine(sb);

//            Console.ReadKey();
//        }
//    }
//}

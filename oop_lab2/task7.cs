using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab2
{
    class task7
    {
        static void Main()
        {
            for (; ; )
            {
                Console.WriteLine("\n1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\n5 - Задание 5\n6 - Задание 6\nВведите вариант\n");
                string q = Console.ReadLine();
                int i = 0;
                if (q == "1" | q == "2" | q == "3" | q == "4" | q == "5" | q == "6")
                {
                    i = Convert.ToInt32(q);
                }

                switch(i)
                {
                    case 1:
                        Console.WriteLine("\nЗадание 1");
                        task1();
                        break;
                    case 2:
                        Console.WriteLine("\nЗадание 2");
                        task2();
                        break;
                    case 3:
                        Console.WriteLine("\nЗадание 3");
                        task3();
                        break;
                    case 4:
                        Console.WriteLine("\nЗадание 4");
                        task4();
                        break;
                    case 5:
                        Console.WriteLine("\nЗадание 5");
                        task5();
                        break;
                    case 6:
                        Console.WriteLine("\nЗадание 6");
                        task6();
                        break;
                    case 7:
                        Console.WriteLine("Выход");
                        return;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }

            void task1()
            {
                bool bl = true; //a
                sbyte sbt = -128;
                char chr = 'c';
                int nt = 2147483647;
                decimal dcml = 10000000000000000000;
                double dbl = 10000000000000000000;
                float flt = 1000000000000000;
                uint unt = 4294967295;
                long lng = 9223372036854775807;
                ulong ulng = 18446744073709551615;
                short shrt = 32767;
                ushort ushrt = 65535;
                Console.WriteLine($"{bl} {sbt} {chr} {nt} {dcml} {dbl} {flt} {unt} {lng} {ulng} {shrt} {ushrt}");

                byte y = 10; //b
                short u = (short)y;
                int i = (int)y;
                float o = (float)i;
                double p = (double)o;
                Console.WriteLine(p);

                byte q = 5; //b
                short w = q;
                int e = w;
                float r = e;
                double t = r;
                Console.WriteLine(t);

                object box1 = t; //c
                double tt = (double)box1;

                var kavo = 5; //d
                int tavo = 5;
                Console.WriteLine(kavo + tavo);

                int? ttt = null; //e
                int? yyy = 5;
                Console.WriteLine(ttt + yyy);

                var names = "ssss";
                //names = 1;
            }

            void task2()
            {
                string first = "that`s first string ";
                string second = "that`s second string ";
                string third = "that`s third string ";
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(third);

                string cnct = String.Concat(first, second, third);
                Console.WriteLine(cnct);
                string cp = String.Copy(first);
                Console.WriteLine(cp);
                string sbstrng = second.Substring(2, 7);
                Console.WriteLine(sbstrng);
                string[] splt = third.Split();
                foreach (string ww in splt)
                {
                    Console.WriteLine(ww);
                }
                string nsrt = first.Insert(7, second);
                Console.WriteLine(nsrt);
                string rmv = third.Remove(0, 7);
                Console.WriteLine(rmv);
                Console.WriteLine($"{first}, {second}, {third}");

                string nul0 = "";
                if (String.IsNullOrEmpty(nul0))
                    Console.WriteLine("nul0 пусто");
                else
                    Console.WriteLine("nul0 не пусто");
                string nul1 = null;
                if (String.IsNullOrEmpty(nul1))
                    Console.WriteLine("nul1 пусто");
                else
                    Console.WriteLine("nul1 не пусто");

                StringBuilder sb = new StringBuilder("StringBuilder", 60);
                Console.WriteLine(sb);
                sb.Remove(0, 6);
                sb.Insert(0, "?");
                sb.Append("?");
                Console.WriteLine(sb);
            }

            void task3()
            {
                int[,] arrint = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
                for (int i = 0; i < arrint.GetLength(0); i++)
                {
                    for (int j = 0; j < arrint.GetLength(1); j++)
                    {
                        Console.Write(arrint[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                string[] arrstr = { "first", "second", "third" };
                foreach (string a in arrstr)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(arrstr.GetLength(0));
                arrstr[0] = "one";
                foreach (string a in arrstr)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();

                int[][] arr1 = new int[3][];
                arr1[0] = new int[2];
                arr1[1] = new int[3];
                arr1[2] = new int[4];

                for (int q = 0; q < arr1.GetLength(0); q++)
                {
                    for (int w = 0; w < arr1[q].GetLength(0); w++)
                    {
                        arr1[q][w] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                for (int q = 0; q < arr1.GetLength(0); q++)
                {
                    for (int w = 0; w < arr1[q].GetLength(0); w++)
                    {
                        Console.Write($"{arr1[q][w]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                var arr2 = new[] { 1, 2, 3 };
                foreach (int x in arr2)
                {
                    Console.Write(x + " ");
                }

                var str = "hello";
                Console.WriteLine(str);
            }

            void task4()
            {
                (int nt, string str1, char ch, string str2, ulong ulng) cort = (-2, "КТО", 'Q', "ДВЕРЬ", 1000000);
                Console.WriteLine($"Это кортеж:{cort}");
                Console.WriteLine($"Выборочно:{cort.Item1} {cort.Item3} {cort.Item4}");
                var (one, two, three, four, five) = cort;
                string str3 = cort.str2;
                Console.WriteLine($"Распоковочка:{one}, {two}, {three}, {four}, {five}, {str3}");
                int diff1 = (5, 4).CompareTo((4, 5));
                int diff2 = (5, 4).CompareTo((5, 4));
                int diff3 = (4, 5).CompareTo((5, 4));
                Console.WriteLine($"{diff1} {diff2} {diff3}");
            }

            void task5()
            {
                string a = "Fun";
                int[] b = { 1, 2, 3 };
                var k = Fun(a, b);
                Console.WriteLine($"{k}");

                object Fun(string str, int[] arr)
                {
                    int max = arr[0], min = arr[0], sum = 0;
                    foreach (int x in arr)
                    {
                        if (x > max)
                        {
                            max = x;
                        }
                        if (x < min)
                        {
                            min = x;
                        }
                        sum += x;
                    }
                    var cort = (max, min, sum, str[0]);
                    return cort;
                }
            }

            void task6()
            {
                Ch();
                Uch();

                void Ch()
                {
                    checked
                    {
                        int a = 2147483647;
                        Console.WriteLine(a);
                    }
                }
                void Uch()
                {
                    unchecked
                    {
                        int a = 2147483647;
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
}
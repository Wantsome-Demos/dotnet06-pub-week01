namespace _02Numbers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var intList = new List<int>();

            intList.Add(1);
            intList.Add(5);
            intList.Add(10);
            intList.Add(20);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            int dimensiuneArray = int.Parse(Console.ReadLine());

            //                         0   1    2   3   4  5
            int[] array = new int[6] { 10, 212, 42, 61, 8, 93 };

            int[] array2 = new int[dimensiuneArray];

            int lung = array.Length;

            // 1
            //for (int i = 0; i < lung; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            // 2
            //int i = 0;
            //while (i < lung)
            //{
            //    Console.WriteLine(array[i]);
            //    i++;
            //}

            // 3
            //int nr = ReadNumber();
            //Console.WriteLine("Nr par introdus: " + nr);

            int min = array[0];                                     // min = 10
            int poz = 0;                                            // poz = 0

            //for (poz = 1; poz < array.Length; poz++)                // poz = 0
            //{
            //    if (min > array[poz])                               // min (10) > array[0] (10)
            //    {
            //        min = array[poz];
            //    }
            //}

            while (poz < array.Length)                // poz = 0
            {
                if (min > array[poz])                               // min (10) > array[0] (10)
                {
                    min = array[poz];
                }

                poz++;
            }

            Console.WriteLine("Min: " + min);

            ////2
            //poz = poz + 1;

            ////3
            //if (min > array[poz])
            //{
            //    min = array[poz];
            //}

            ////4
            //if (poz > array.Length)
            //{
            //    //stop
            //}
            //else
            //{
            //    //jump to step 2
            //}

        }

        private static int ReadNumber()
        {
            //Console.WriteLine("Insert number: ");
            //int n = int.Parse(Console.ReadLine());

            //while (n % 2 != 0)
            //{
            //    Console.WriteLine("Insert number: ");
            //    n = int.Parse(Console.ReadLine());
            //}

            int n;
            do
            {
                Console.WriteLine("Insert number: ");
                n = int.Parse(Console.ReadLine());
            } while (n % 2 != 0);

            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("Nr par");
            //}
            //else
            //{
            //    Console.WriteLine("Nr impar");
            //}

            return n;
        }
    }
}

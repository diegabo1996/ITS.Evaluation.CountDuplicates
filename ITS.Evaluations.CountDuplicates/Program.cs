using System;

namespace ITS.Evaluations.CountDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int s, mm = 1, ctr = 0;
            int i, j;
            Console.Write("\n\nCount total number of duplicate items in an array:\n");

            Console.Write("Input the number of items to be stored in the array :");
            s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} items in the array :\n", s);
            for (i = 0; i < s; i++)
            {
                Console.Write("item - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < s; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            for (i = 0; i < s; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate items is: {0} \n", ctr);

            Console.Write("\n\n");
        }
    }
}
 
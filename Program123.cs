using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static int[][] InputArray(int n)
        {
            int[][] mas; string[] s;
            mas = new int[n][];
            for (int i =0; i < mas.Length; i++)
            {
                Console.WriteLine("Введите количество элементов в {0} сстроке: ", i);
                mas[i] = new int[int.Parse(Console.ReadLine())];
                Console.WriteLine("Введите элементы через пробел: ");
                s = Console.ReadLine().Split(new char[] {' '});
                int j = 0;
                foreach (string index in s)
                {
                    mas[i][j] = int.Parse(index);
                    j++;
                }
            }
            return mas;
        }
        static void OutPut(int[][] mas)
        {
            foreach (int[] i in mas)
            {
                foreach (int j in i)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[] Menshee(int[][] mas)
        {
            int k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (mas[i][j] < 0)
                    {
                        k++;
                    }
                }
            }
            if (k == 0)
            {
            }
            int[] arr = new int[k];
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (mas[i][j] < 0)
                    {
                        arr[j] = mas[i][j];
                    }
                }
            }
            int temp = 0;
            for (int o = 0; o < arr.Length - 1; o++)
            {
                if (arr[o] > arr[o + 1])
                {
                    temp = arr[o + 1];
                    arr[o + 1] = arr[o];
                    arr[o] = temp;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            OutPut(InputArray(n));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bassini_ThreadRicerca
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            generaACaso(arr);
            Thread t1 = new Thread(() => cercaNumero(3, arr));
            t1.Start();
            cercaNumero(5, arr);
            Console.Read();


        }
        static void cercaNumero(int n,int[] arr)
        {
            int trovato = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    trovato = i;
                }
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "-Trovato:" + trovato);
        }
        static void generaACaso(int[]arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            
        }
    }
}

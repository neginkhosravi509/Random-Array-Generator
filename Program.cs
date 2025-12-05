using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araye
{
    class Program
    {
        static void FAP(int [] a,int i, Random r)
        {
            if (i >= a.Length)
            return;
            //عدد تصادفی بین یک تا صد
            a[i] = r.Next(1, 101);
            Console.WriteLine(a[i]+" ");
            //فراخوانی بازگشتی بعدی
            FAP(a, i + 1, r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter count array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rnd = new Random();
            FAP(arr, 0, rnd);
            Console.ReadKey();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("phan tu thu{0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            isPrime(n);
            //    Console.Write("cac so nguyen to la:{0} ", isPrime(n));
            //    countPrime(a, n);


              Console.ReadKey();
            //    }
            //static int countPrime(int[] a, int n)
            //{

            //    {
            //        int count = 0;  
            //        for (int i = 0; i < n; i++)
            //        {
            //            if (isPrime(a[i]))
            //            {

            //                count++;
            //                 Console.Write(" {0} ", count);
            //            }
            //        }
            //        return count;

            //    }
            //}
        }
        public static bool isPrime(int n)
        {
            if (n < 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

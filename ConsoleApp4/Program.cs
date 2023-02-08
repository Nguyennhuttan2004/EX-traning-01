using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhapp n:");
            int n = int.Parse(Console.ReadLine());
            int[] a;
            inputArr(out a, n);
            outputArr(a);
            Trungbinhcong(a, n);
            int TB= (int)Trungbinhcong(a,n);
            Console.WriteLine("tb :{0}", TB);
            Console.ReadKey();
           
        }
        static void inputArr(out int[] a, int n)
        {
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("please enter item {0}: ", i + 1);
                int num = int.Parse(Console.ReadLine());
                a[i] = num;
            }
        }
        static void outputArr(int[] a)
        {
            Console.Write("Array: ");
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.Write("]");
        }
        public static bool hasEvenNumber(int n)
        {

            if (n % 2 == 0)
            {
                return true;
            }
            else
                return false;

        }
        static double Trungbinhcong(int[]a,int n)
        {
            Double TB = 0;
            int sum = 0;
            for(int i =0; i < a.Length; i++)
            {
                sum = sum + a[i];   
                TB= sum / a[i];

            }
             return TB;
        }
    }
}

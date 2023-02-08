using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write(" nhap gia tri cac phan tu: ");
                int n = int.Parse(Console.ReadLine());
                int[] mang = new int[n];

                NhapMang(ref mang, n);
                XuatMang(ref mang);
                Console.WriteLine("*--------------------------* ");
                NhapMang1(ref mang, n);
                XuatMang(ref mang);
                Console.ReadKey();

            }
        }
            static void NhapMang(ref int[] mang, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap gia tri mang[{i}]:  ");
                    mang[i] = int.Parse(Console.ReadLine());
                }
            }
            static void NhapMang1(ref int[] mang, int n)
            {
                Console.Write($"nhap gia tri cac phan tu:  ");
                n = int.Parse(Console.ReadLine());
                mang = new int[n];
                NhapMang(ref mang, n);
            }
            static void XuatMang(ref int[] mang)
            {
                for (int i = 0; i < mang.Length; i++)
                {
                    Console.Write(mang[i] + "  ");
                }
                Console.WriteLine();
            }
    }
}

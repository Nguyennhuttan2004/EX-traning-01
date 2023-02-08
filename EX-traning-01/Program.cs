using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EX_traning_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            int[] a;

            inputArr(out a, n);
            outputArr(a);
            menu();
            Console.WriteLine("your choise: ");

            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.Write("please enter number 1 to text funtions: ");
            int choise = int.Parse(Console.ReadLine());
            while (true)
            {

                switch (choise)
                {
                    case 1:
                        menu1();
                        Console.Write("choise ex count : ");
                        int x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;
                            case 1:
                                Console.Write("Please enter number : ");
                                int numb = int.Parse(Console.ReadLine());
                                if (isPrime(numb))
                                {
                                    Console.WriteLine("It is prime");
                                }
                                else
                                {
                                    Console.WriteLine("It is not prime");
                                }
                                break;

                            case 2:
                                Console.Write("Please enter number : ");
                                int num = int.Parse(Console.ReadLine());
                                if (isPerfect(num) == true)
                                {
                                    Console.WriteLine("It is perfect number ");
                                }
                                else
                                {
                                    Console.WriteLine("It isnot  perfect number ");
                                }
                                break;
                            case 3:
                                Console.Write("Please enter number:  ");
                                int ber = int.Parse(Console.ReadLine());

                                if (hasEvenNumber(ber) == true)
                                {
                                    Console.WriteLine("It is even number ");
                                }
                                else
                                {
                                    Console.WriteLine("It is not even number ");
                                }
                                break;
                                break;
                            case 4:
                                Console.Write("Please enter number : ");
                                int odd = int.Parse(Console.ReadLine());
                                if (hasOddNumber(odd) == true)
                                {
                                    Console.WriteLine("It is odd number ");
                                }
                                else
                                {
                                    Console.WriteLine("It isn't odd number ");
                                }
                                break;
                            case 5:
                            default:
                                Console.WriteLine("                                                                       ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.Write(" ^ ^  PLEASE ENTER AGAIN  ^ ^  ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.WriteLine("                                                                       ");
                                break;

                        }

                        break;


                    case 2:
                        menu2();
                        Console.Write("Please enter number : ");

                        int x2 = int.Parse(Console.ReadLine());
                        switch (x2)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;

                            case 1:
                                Console.Write("Enter n:");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                countPrime(a, n);

                                int pirmeCount = countPrime(a, n);
                                Console.Write("the number of primes:{0}", pirmeCount);

                                break;

                            case 2:
                                Console.Write("Enter n :");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                countPerfect(a, n);

                                int perfectCount = countPerfect(a, n);
                                Console.Write("the number of perfect:{0}", perfectCount);

                                break;
                            case 3:
                                Console.Write("Enter n :");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                countEvenNumber(a, n);

                                int EvenNumberCount = countEvenNumber(a, n);
                                Console.Write("Even number of numbers:{0}", EvenNumberCount);

                                break;
                            default:
                                Console.WriteLine("                                                                       ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.Write(" ^ ^  PLEASE ENTER AGAIN  ^ ^  ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.WriteLine("                                                                       ");
                                break;
                        }
                        break;


                    case 3:
                        menu3();
                        Console.Write("Please enter number : ");

                        int x3 = int.Parse(Console.ReadLine());
                        switch (x3)
                        {
                            case 0:
                                Environment.Exit(0);
                                break;

                            case 1:
                                {
                                    Console.Write("Enter n:");
                                    n = int.Parse(Console.ReadLine());
                                    inputArr(out a, n);
                                    toTalEvenNumber(a, n);
                                    toTalOddNumber(a, n);
                                    int totalOddNumber = toTalOddNumber(a, n);
                                    int totalEvenNumber = toTalEvenNumber(a, n);
                                    Console.Write("totals even number in array: {0}   ", totalEvenNumber);

                                    Console.Write("totals odd number in array: {0}   ", totalOddNumber);
                                }
                                break;
                            case 2:

                                Console.Write("Enter n:");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                toTalAvarage(a, n);
                                float totalava = toTalAvarage(a, n);

                                Console.Write("totals avarage in array: {0}   ", totalava);
                                break;
                            case 3:
                                Console.Write("Enter n:");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                toTalPrimeNumber(a, n);
                                int totalprimenumber = toTalPrimeNumber(a, n);

                                Console.Write("totals prime number in array: {0}   ", totalprimenumber);
                                break;
                            case 4:
                                Console.Write("Enter n:");
                                n = int.Parse(Console.ReadLine());
                                inputArr(out a, n);
                                toTalPerfectNumber(a, n);
                                int totalperfectnumber = toTalPerfectNumber(a, n);

                                Console.Write("totals prime number in array: {0}   ", totalperfectnumber);
                                break;
                            default:
                                Console.WriteLine("                                                                       ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.Write(" ^ ^  PLEASE ENTER AGAIN  ^ ^  ");
                                Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                                Console.WriteLine("                                                                       ");
                                break;

                        }
                        break;
                    case 4:


                        menu4();
                        Console.Write("Please enter number : ");

                        int x4 = int.Parse(Console.ReadLine());
                        switch (x4)
                        {

                            case 0:
                                Environment.Exit(0);
                                break;

                            case 1:
                                {
                                    Console.Write("Enter n:");
                                    n = int.Parse(Console.ReadLine());
                                    inputArr(out a, n);
                                    ListEvenPositiveNumber(a, n);
                                }
                                break;

                            case 2:
                                {
                                    Console.Write("Enter n:");
                                    n = int.Parse(Console.ReadLine());
                                    inputArr(out a, n);
                                    ListOddNegativeNumber(a, n);
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("Enter n:");
                                    n = int.Parse(Console.ReadLine());
                                    inputArr(out a, n);
                                    ListPrimeNumber(a, n);
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("Enter n:");
                                    n = int.Parse(Console.ReadLine());
                                    inputArr(out a, n);
                                    ListPerfectNumber(a, n);

                                }
                                break;

                        }
                        break;
                    case 5:
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        outMaxNumber(a, n);
                        int outmax = outMaxNumber(a, n);
                        Console.Write("Max Number:  {0}  ",outmax);   
                        break;
                     case 6:
                        
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        outMaxPrimeNumber(a,n);
                        int maxprimenumber= outMaxPrimeNumber(a, n);
                        Console.WriteLine("     Max Prime Number:  {0}    ", maxprimenumber);
                        Console.WriteLine("                                             ");
                        break;
                     case 7:
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        outMinPerfectNumber(a, n);
                        int maxperfectnumber = outMinPerfectNumber(a, n);
                        Console.WriteLine("      Max Perfect Number:  {0}    ", maxperfectnumber);
                        Console.WriteLine("                                             ");
                        break;
                     case 8:
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        comPare(a, n);
                        break;
                    case 9:
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        outFirstPrimeNumber(a, n);

                        int outfirstprimenum = outFirstPrimeNumber(a, n);
                        Console.WriteLine("The First Prime Number: {0}", outfirstprimenum);
                        Console.WriteLine("                                                                       ");
                        break;
                    case 10:
                        Console.Write("Enter n:  ");
                        n = int.Parse(Console.ReadLine());
                        inputArr(out a, n);
                        outLastEvenNumber(a, n);

                        int outlastevennum = outLastEvenNumber(a, n);
                        Console.WriteLine("The Last Even Number: {0}", outlastevennum);
                        Console.WriteLine("                                                                        ");
                        break;
                    case 11:
                        int c, b;
                        Console.Write("Enter a:");
                        c = int.Parse(Console.ReadLine());
                        Console.Write("Enter b: ");
                        b= int.Parse(Console.ReadLine());   
                        if ( c>0 && b>0 )
                        {
                            for ( int i =c;i<=b;i++ )
                            {
                                if (isPrime(i)== true)
                                {
                                    Console.WriteLine("output prime number int array [50,100]: {0}", i);
                                }
                            }
                        }


                       
                       
                        break;
                    
                    default:
                        Console.WriteLine("                                                                       ");
                        Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                        Console.Write(" ^ ^  PLEASE ENTER AGAIN  ^ ^  ");
                        Console.Write("xxxxxxxxxxxxxxxxxxxxx ");
                        Console.WriteLine("                                                                       ");
                        break;
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }



        static void menu()
        {


            Console.WriteLine("                                      ");
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                 MENU                                       |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|1. check the number of:                                                     |");
            Console.WriteLine("|2. count the number of:                                                     |");
            Console.WriteLine("|3. calculate the sum of an array:                                           |");
            Console.WriteLine("|4. list even and odd numbers:                                               |");
            Console.WriteLine("|5. output the largest number:                                               |");
            Console.WriteLine("|6. output the largest prime number:                                         |");
            Console.WriteLine("|7. output the smallest perfect number:                                      |");
            Console.WriteLine("|8. Compare the number of primes versus the number of perfects:              |");
            Console.WriteLine("|9. output the first prime number appearing in an array:                     |");
            Console.WriteLine("|10. Write a program to output the last positive number in an array:         |");
            Console.WriteLine("|11.List primes in the range [50,100]:                                       |");
            Console.WriteLine("|0. Exit program:                                                            |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------+");

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
        static void menu1()
        {


            Console.WriteLine("                                      ");
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                 MENU                                       |");
            Console.WriteLine("|1. text the prime number :                                                  |");
            Console.WriteLine("|2. text the perfect number :                                                |");
            Console.WriteLine("|3. text  the even number :                                                  |");
            Console.WriteLine("|4. text  the odd  number :                                                  |");
            Console.WriteLine("|0. Exit program:                                                            |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------+");

        }
        static void menu2()
        {


            Console.WriteLine("                                      ");
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                 MENU                                       |");
            Console.WriteLine("|1. count the number of prime :                                              |");
            Console.WriteLine("|2. count the number of perfect :                                            |");
            Console.WriteLine("|3. count the number of even :                                               |");
            Console.WriteLine("|0. Exit program:                                                            |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------+");
        }
        static void menu3()
        {


            Console.WriteLine("                                      ");
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                 MENU                                       |");
            Console.WriteLine("|1. calculate even and odd totals                                            |");
            Console.WriteLine("|2. calculate avagare totals in array                                        |");
            Console.WriteLine("|3. calculate prime number totals                                            |");
            Console.WriteLine("|4. calculate perfect number totals                                          |");
            Console.WriteLine("|0. Exit program:                                                            |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------+");
        }


        static void menu4()
        {


            Console.WriteLine("                                      ");
            Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                                 MENU                                       |");
            Console.WriteLine("|1. List evenpositive number                                                 |");
            Console.WriteLine("|2. List oddnegative number                                                  |");
            Console.WriteLine("|3. List prime number                                                        |");
            Console.WriteLine("|4. List perfect number                                                      |");
            Console.WriteLine("|0. Exit program:                                                            |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+----------------------------------------------------------------------------+");
        }
        // check
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
        public static bool isPerfect(int n)
        {
            int sum = 0;
            if (n < 1) return false;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            else
                return false;
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
        public static bool hasOddNumber(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        // count đếm 

        static int countPrime(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]))
                    count++;

            }
            return count;

        }
        static int countPerfect(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPerfect(a[i]))
                    count++;

            }
            return count;
        }
        static int countEvenNumber(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (hasEvenNumber(a[i]))
                    count++;

            }
            return count;
        }

        // stotal tinhs tổng

        static int toTalEvenNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)

            {
                if (hasEvenNumber(a[i]))
                    sum += a[i];
            }
            return sum;
        }
        static int toTalOddNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)

            {
                if (hasOddNumber(a[i]))
                    sum += a[i];
            }
            return sum;
        }
        static float toTalAvarage(int[] a, int n)
        {
            float sum = 0;
            float avarage = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                avarage = (float)(sum / (1.0 * a[i]));
            }
            return avarage;
        }
        static int toTalPrimeNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]) == true)

                    sum = sum + a[i];

            }
            return sum;
        }
        static int toTalPerfectNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPerfect(a[i]) == true)

                    sum = sum + a[i];

            }
            return sum;
        }

        //total


       // Liệt kê số chẵn dương 
        static void ListEvenPositiveNumber(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {

                if (hasEvenNumber(a[i]) && a[i] > 0)
                    Console.WriteLine("list even positive number:   {0}  ", a[i]);
            }
        }// Liệt kê số lẻ âm
        static void ListOddNegativeNumber(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {

                if (hasOddNumber(a[i]) && a[i] < 0)
                    Console.WriteLine("list odd negative number:    {0}  ", a[i]);
            }
        }
      //  Liệt kê số nguyên tố
        static void ListPrimeNumber(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {

                if (isPrime(a[i]))
                    Console.WriteLine("list prime number:    {0}  ", a[i]);
            }
        }
        //Liệt kê số hoàn thiện
        static void ListPerfectNumber(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {

                if (isPerfect(a[i]))
                    Console.WriteLine("list perfect number:    {0}  ", a[i]);
            }
        }
        //xuất ra số lớn nhất
        static int outMaxNumber(int[] a, int n)
        {
            int max = a[0];
            for(int i=0; i<a.Length;i++)
            {
                if (max < a[i])
                    max= a[i];
            }
            return max;
        }
        //xuất ra số nguyên tố lớn nhất
        static int outMaxPrimeNumber(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i])== true)
                {
                    if (max < a[i])
                        max = a[i];
                }
            }
            return max;
        }
        // xuất ra số hoàn thiện nhỏ nhất
        static int outMinPerfectNumber(int[]a, int n)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (isPerfect(a[i]) == true)
                {
                    if (min > a[i])
                        min = a[i];
                }
            }
            return min;
        }
        // so sanh số lượng số nguyên tố với số lượng số hoàn hảo 
        static void comPare(int[] a, int n)
        {
            int countPrimeNum = countPrime(a, n);
            int countPerfectNum=countPerfect(a, n); 
          
                if(countPrimeNum> countPerfectNum)
                { Console.WriteLine(" The number of Primes  ({0})  GREATER THAN  The number of Perfect  ({1}) ", countPrimeNum, countPerfectNum); }
                else if(countPrimeNum < countPerfectNum)
                { Console.WriteLine(" The number of Primes  ({0})  SMALLER THAN  The number of Perfect  ({1})  ",countPrimeNum, countPerfectNum); }
                else
                { Console.WriteLine(" The number of Primes  ({0})  EQUAL TO  The number of Perfect  ({1})  ", countPrimeNum, countPerfectNum); }

        }
        // xuất số nguyên tố đầu tiên trong mảng 
        static int outFirstPrimeNumber(int[]a, int n)
        {
            for(int i=0; i<a.Length;i++)
            {
                if (isPrime(a[i]) == true)
                    return a[i];
            }
            return 0;
        }

        // xuất số dương cuối cùng trong mảng 

        static int outLastEvenNumber(int[] a,int n)
        {
            for(int i=n-1;i>=0;i--)
            {
                if (a[i] >0)
                if (hasEvenNumber(a[i])== true)
                {
                    return a[i];
                }
            }
            return 0;
        }
       
    }
}







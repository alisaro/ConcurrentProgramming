//This program calculate the fuction PerfectNumber showing the time that spent in this calculation
//in normal for loop and in parallel for loop

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class ThreadNaming
{
    static void Main()
    {

        //main threads
        GoPerfect(2, 120000, "Normal For Loop --> ");
        //GoPerfect(35001, 80000, "main thread (2) --> ");

        Console.WriteLine("---------------------");

        //Thread task2 = new Thread(() => GoPerfect(2, 35000, "2nd thread ------>"));
       GoPerfectParallel(2, 120000, "Parallel For Loop ------>");
        

        //Thread task3 = new Thread(() => GoPerfect(35001, 80000, "3rd thread ------> "));
        //Task task3 = new Task(() => GoPerfect(35001, 50000, "3rd thread ------> "));
        //task3.Start();

        //Task task4 = new Task(() => GoPerfect(50001, 80000, "4rd thread ------> "));
        //task4.Start();

        Console.ReadKey();

    }


    static bool PerfectNumbersParallel(long n)
    {
        long s = 0;
        long m = n / 2 + 1;
        Parallel.For(1, m, i =>
        {
            if (n % i == 0)
            {
                s += i;
            }
        });

        if (n == s) return true;
        else return false;
    }

    static bool PerfectNumbers(long n)
    {
        long s = 0;
        for (int i = 1; i <= n / 2 + 1; i++)
        {
            if (n % i == 0)
            {
                s += i;
            }
        }
        if (n == s) return true;
        else return false;
    }


    static void GoPerfectParallel(int a, int b, string m)
    {
        Stopwatch sw = Stopwatch.StartNew();
        Console.WriteLine(m + "PerfectNumber: {0:f2} s", sw.Elapsed.TotalSeconds);
        //string start = DateTime.Now.ToString("HH:mm:ss tt");
        //Console.WriteLine(m + " - " + start);
        for (int i = a; i <= b; i++)
        {
            if (PerfectNumbersParallel(i))
            {
                Console.WriteLine(m + " - " + i);
            }
        }

        Console.WriteLine(m + "PerfectNumber: {0:f2} s", sw.Elapsed.TotalSeconds);
        //string stop = DateTime.Now.ToString("HH:mm:ss tt");
        //Console.WriteLine(m + " - " + stop);

    }

    static void GoPerfect(int a, int b, string m)
    {
        Stopwatch sw = Stopwatch.StartNew();
        Console.WriteLine(m + "PerfectNumber: {0:f2} s", sw.Elapsed.TotalSeconds);

        //string start = DateTime.Now.ToString("HH:mm:ss tt");
        //Console.WriteLine(m + " - " + start);
        for (int i = a; i <= b; i++)
        {
            if (PerfectNumbers(i))
            {
                Console.WriteLine(m + " - " + i);
            }
            //if (i % 1000 == 0) { Console.Write("."); }

        }
        

        Console.WriteLine(m + "PerfectNumber: {0:f2} s", sw.Elapsed.TotalSeconds);
        //string stop = DateTime.Now.ToString("HH:mm:ss tt");
        //Console.WriteLine(m + " - " + stop);

    }

}
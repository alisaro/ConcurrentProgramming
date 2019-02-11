//This program calculate the fuction PerfectNumber showing the time that spent in this calculation
//in each threads

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class ThreadNaming
{
    static void Main()
    {

        //main threads
        GoPerfect(2, 35000, "main thread (1)--> ");
        GoPerfect(35001, 80000, "main thread (2) --> ");

        Console.WriteLine("---------------------");

        //Call GoPerfect() on a new thread
        Thread task2 = new Thread(() => GoPerfect(2, 35000, "2nd thread ------>"));
        task2.Start();

        //Call GoPerfect() on a new thread
        Thread task3 = new Thread(() => GoPerfect(35001, 80000, "3rd thread ------> "));
        task3.Start();


        Console.ReadKey();

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
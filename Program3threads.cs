using System;
using System.Threading;


class ThreeThreads
{
    static void Main()
    {
        Thread t2 = new Thread(WriteAlbero);          // Kick off a new thread
        t2.Start();                                   // running WriteAlbetro()

        Thread t3 = new Thread(WriteAngelo);          // Kick off a new thread
        t3.Start();                                   // running WriteAngelo() 

        // The main thread.
        for (int i = 0; i < 1000; i++) Console.Write("Alicia ");

        Console.ReadKey();
    }

    // The second thread.
    static void WriteAlbero()
    {
        for (int i = 0; i < 1000; i++) Console.Write("Alberto ");
    }

    // The third thread.
    static void WriteAngelo()
    {
        for (int i = 0; i < 1000; i++) Console.Write("Angelo ");
    }
}
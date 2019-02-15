
 # Simple Parallel. For Loop (C#)
 ###  Is a simple data parallelism
 ####  Execution in serial and parallel form
```c#
for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                //Execution in serial form
                Serial(array, 2);
		//time that need serial form
                Console.WriteLine("Serial: {0:f2} s", sw.Elapsed.TotalSeconds);

                sw = Stopwatch.StartNew();
                //Execution en parallel form
                ParallelFor(array, 2);
		//time that need parallel form
                Console.WriteLine("Parallel.For: {0:f2} s", sw.Elapsed.TotalSeconds);
            }
```
 #### Serial Function (Main thread)
```c#
static void Serial(double[] array, double factor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * factor;
            }

        }
````

 ####Parallel Function 
>  the source collection is partitioned so that 
multiple threads can operate on different segments 
concurrently.
```c#
 static void ParallelFor(double[] array, double factor)
        {
            Parallel.For(
                0, array.Length, i => { array[i] = array[i] * factor; });
        }
```
 ###  Output ForLoop.cs
> As we can see the parallel form take less time 
that serial form. 
![ForLoop](ForLoop.PNG)

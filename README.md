* LINQ_4.cs  LINQ Query
  * The following example shows how the 
three parts of a query operation are expressed 
in source code. The example uses a collection Student as a data source.

* ForLoop.cs  Simple parallelism For Loop
  * This program execute the same code in serial mode and with parallel for loop threads.
As is normal to wait, the result of time is less in part ParallelFor because different threads  
calculate the multiplication in each iteration.
In serial part the time is big because the same thread have to calculate the multiplication in each iteration.

* Threads_PerfectNumber.cs with threads
  * This program calculate the fuction PerfectNumber showing the time that spent in this calculationin each threads
* Tasks_PerfectNumber.cs with tasks
  * This program calculate the fuction PerfectNumber showing the time that spent in this calculation in each threads or task

* Program3threads.cs multithreads
 
* Countries.cs 
```c#
var result = from c in Countries
            where (c.Continent == 
theContinent) && (c.Population / c.Area > 
theDensity)
            orderby c.Population/c.Area 
descending
            select c;
```

![ForLoop](ForLoop/ForLoop.PNG)

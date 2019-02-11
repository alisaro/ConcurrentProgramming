* LINQ_4.cs concurrent programming
* PerfectNumber.cs with parallel for
* Program3threads.cs multithreads
* ForLoop.cs
*countries.cs 
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

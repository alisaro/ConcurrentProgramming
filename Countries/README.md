 # LINQ Queries with a file information (C#)

 ### Version 1: countries.cs 

 #### Step 1: create the data source, this time 
from a file data.csv
```c#
 IEnumerable<Country> Countries = GetCountries();
```
```c#
 public static IEnumerable<Country> GetCountries()
    {
        var countries = System.IO.File.ReadAllLines("data.csv");
 
		
        return (from line in countries
                let fields = line.Split(',')
                
                select new Country()
                {
                    Name = fields[0].Trim(),
                    Continent = fields[1].Trim(),
                    Population = Convert.ToInt32(fields[2]),
                    Area = Convert.ToInt32(fields[3].Trim()),	
                    Gdp2010 = Convert.ToDouble(fields[6].Trim())
                });
               
    }
```
 #### Step 2: Query creation:

 > This query take the countries (from the 
Continent that we choise) with density higher than 
100 and order the countries by descending density 

```c#
 var result = from c in Countries
            where (c.Continent == theContinent) && (c.Population / c.Area > 100)
            orderby c.Population/c.Area descending
            select c;
```
 #### Step 3: Query execution 

 > Show the Name of the country, Population of this country, Area and Density

```c#
foreach(Country c in result){
            Console.WriteLine(String.Format("{0, -25} {1, 15:n0} {2, 15:n0} {3, 10:n1}", c.Name, c.Population, c.Area, (1.0*c.Population/c.Area)));
        }  
```


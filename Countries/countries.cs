//For the execution in command-line:  
//countries.exe <continent name>

//This program obtain the Data Base from a file named data.csv and keep this information in IEnumerable<Country> Countries.
//After this the program does a LINQ Query where show the countries with density higher to 100 of a Continent (that we add like first parameter)
//Finally this program show the total of Countries that pass this condition instead of this Continent, and information about this Counties like
//Name of the country, Population of this country, Area and Density

using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.IO;


class CoutriesOfTheWorld
{

    public static void Main()
    {


        String[] args = Environment.GetCommandLineArgs();
        if (args.Length == 1 ) {
         Console.WriteLine("There are no command line arguments.");
         return;
        }

        String theContinent = args[1];


    	IEnumerable<Country> Countries = GetCountries();
        Console.WriteLine("The number of countries: {0}", Countries.Count());  
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine(String.Format("{0, -25} {1, 15:n0} {2, 15:n0} {3, 10:n1}", "Country", "Population", "Area", "Density"));   
        Console.WriteLine("------------------------------------------------------------------------");


        var result = from c in Countries
            where (c.Continent == theContinent) && (c.Population / c.Area > 100)
            orderby c.Population/c.Area descending
            select c;

        foreach(Country c in result){
            Console.WriteLine(String.Format("{0, -25} {1, 15:n0} {2, 15:n0} {3, 10:n1}", c.Name, c.Population, c.Area, (1.0*c.Population/c.Area)));
        }   

        Console.WriteLine("------------------------------------------------------------------------");


    }


       public class Country
	    {
	        public string Name { get; set; }
	        public string Continent { get; set; }
	        public int Population { get; set; }
	        public int Area { get; set; }
	        public double Gdp2010 { get; set; } 

	    }

   
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


    
}

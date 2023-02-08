using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet solarsystem = new Planet();
            int count = 0;
            int plutonumber = 0;
            List<string> planetcollection = solarsystem.Addlist();
            foreach (string planet in planetcollection)
            {
                if (planet == "Pluto")
                    plutonumber = count;
                Console.WriteLine(planet);
                count++;
            }
            Console.WriteLine(planetcollection.Count);
            planetcollection.Remove("Pluto");
            Console.ReadLine();
            //------------------------------------------------


            foreach (string planet in planetcollection)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine(planetcollection.Count);
            Console.ReadLine();
            //------------------------------------------------


            planetcollection.Insert(plutonumber, "Pluto");
            foreach (string planet in planetcollection)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine(planetcollection.Count);
            Console.ReadLine();
            //------------------------------------------------


            List<string> planettemp = solarsystem.Addlist();
            planettemp.Remove("Merkur");
            planettemp.Remove("Jorden");
            planettemp.Remove("Venus");
            foreach (string planet in planettemp)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine(planettemp.Count);
            Console.ReadLine();
            //------------------------------------------------


            List<string> planetdiameter = new List<string>();
            planetdiameter.Add("Venus");
            planetdiameter.Add("Jorden");
            planetdiameter.Add("Mars");
            planetdiameter.Add("Neptun");
            foreach (string planet in planetdiameter)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine(planetdiameter.Count);
            Console.ReadLine();
            //------------------------------------------------


            planetcollection.Clear();
            planettemp.Clear();
            planetdiameter.Clear();
            Console.WriteLine(planetcollection.Count);
            Console.WriteLine(planettemp.Count);
            Console.WriteLine(planetdiameter.Count);
            Console.ReadLine();
        }
    }   //Yea this was a fucking weird "test".
}


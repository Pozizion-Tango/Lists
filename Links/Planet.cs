using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    //Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun, Pluto
    internal class Planet
    {
        public List<string> planet = new List<string> {  "Merkur","Jorden","Mars","Jupiter","Saturn","Uranus","Neptun","Pluto" };
        public List<string> Addlist()
        {
            planet.Insert(1, "Venus");
            return planet;
        }
    }
}

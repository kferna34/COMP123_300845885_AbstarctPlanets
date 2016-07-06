using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    * Author: Krytia Fernandez, 300845885
    * Date Last modified : july 6,2016
    * Description: a program that implements the classes and interfaces
    * version : 0.0.0.10 --final== just more internal documentation needed
    * 
    */
namespace COMP123_300845885_AbstarctPlanets
{/// <summary>
/// this is the driver class
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            GiantPlanet gPlanet = new GiantPlanet("CodingPlanet",52222000, 0000000, "dark");
            Console.WriteLine(gPlanet.ToString());
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            TerrestrialPlanet tPlanet = new TerrestrialPlanet("pluto", 2365, 8954, true);
            Console.WriteLine(tPlanet.ToString());
            Console.WriteLine();
            waitForAnyKey();

        }

        public static void waitForAnyKey()
        {
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
        }
    }
}

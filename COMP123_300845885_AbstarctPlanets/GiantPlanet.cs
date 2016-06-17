using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public bool _hasMoons
        {
            get
            {
                return this._hasMoons;
                
            }

            set
            {
                this._hasMoons = value;
            }
        }

        public bool _hasRings
        {
            get
            {
                return this._hasRings;
            }
            set
            {
                    this._hasRings = value;
            }
        }

        /// <summary>
        /// holds the string that will describe the type of planet
        /// </summary>
        public string Type()
        {
            Console.WriteLine("What type of planet is this planet? --- Gas or Ice? ");
            Console.ReadLine();
            return this._type;
        }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            
            


        }
    }
}// end for the document
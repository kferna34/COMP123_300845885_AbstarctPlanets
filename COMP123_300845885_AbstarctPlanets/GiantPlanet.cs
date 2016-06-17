using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        bool _hasRings = true;
        bool _hasMoons = true;
        private string _type;
       
        

        /// <summary>
        /// holds the string that will describe the type of planet
        /// </summary>
        public bool HasRings()

        {
            if (RingCount != 0)
            {
                return _hasRings;
            }
            else
            {
                return false;
            }

        }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            type = "gass";

        }
        public bool HasMoons()
        {
            if (MoonCount != 0)
            {
                return this._hasMoons;
            }
            else
            {
                return false;
            }
        }
    }
}// end for the document
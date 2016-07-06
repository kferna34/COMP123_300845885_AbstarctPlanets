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
                return true;
            }
            else
            {
                return false;
            }

        }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;

        }
        /// <summary>
        /// Hasmoon() returns true 
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if (MoonCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}// end for the document
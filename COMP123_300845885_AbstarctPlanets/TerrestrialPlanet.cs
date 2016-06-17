using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        bool _hasMoons;
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
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
}
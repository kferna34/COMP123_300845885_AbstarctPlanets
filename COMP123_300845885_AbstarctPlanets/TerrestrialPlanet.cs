using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        public TerrestrialPlanet():base(name)
        {
            throw new System.NotImplementedException();
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}
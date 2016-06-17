using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;
        public string Type()
        {
            this.Type = _type;
        }
    
        public GiantPlanet(string name, double diameter, double mass,string type) : base(name, diameter, mass)
        {
            
        }

     

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}
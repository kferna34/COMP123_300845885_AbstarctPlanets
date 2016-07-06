using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    /// <summary>
    /// this class is a subclass of the planet abstract class. will also implement ihasmoon and ihabitable interfaces
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        public TerrestrialPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this.Oxygen = Oxygen;
        }

            private bool _oxygen;

        //~~~~~~~~~~~~~~~~~~~~~~~PUBLIC PROPERTY~~~~~~~~~~~~~~~~~~~~~~
        /// <summary>
        /// THIS IS A PROPERTY FOR _OXYGEN FIELD
        /// </summary>
        public bool Oxygen
        {
            get
            {
                return this._oxygen;
            }
            set
            {
                this._oxygen = value;
            }
        }
        /// <summary>
        /// this public method Habitable() will return true if the oxygen instance variable is set to true
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (Oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this public method HasMethod() will return true if the moonCount property is greater than zero
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
}
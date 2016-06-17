using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    /*
     * Author: Krytia Fernandez, 300845885
     * Date Last modified : June 16,2016
     * Description: a program athat implements the classes and interfaces
     * version : 0.0.0.4 -- did planet.cs .... fixed the fields  which is the get set;
     * 
     */
    public abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get
            {
                return this._diameter;
            }

        }

        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }

            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        public double RotationalPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }
        public   Planet(string name,double diameter,double mass)
        {
            this._name = Name;
            this._diameter = Diameter;
            this._mass = Mass;

        }

        public override string ToString()
        {
            return base.ToString();
        }
        

        

    }
}
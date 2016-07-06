using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    /*
     * Author: Krytia Fernandez, 300845885
     * Date Last modified : June 30,2016
     * Description: a program that implements the classes and interfaces
     * version : 0.0.0.7 -- giant planet done.. still needs to connect things up byt the feilds and casses are done... others are not done-- to be continued
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
        public   Planet(string name,double diameter,double mass) // wehere the vars are assigned
        {
            name = "Mars";
            diameter = 11;
            mass = 56;
          

        }

        public override string ToString()
        {
            return string.Format(" Planet {0} is {1} and weights {2}", Name,Diameter,Mass);
        }
        

        

    }
}
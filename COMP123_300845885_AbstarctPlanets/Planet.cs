using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    /*
     * Author: Krytia Fernandez, 300845885
     * Date Last modified : july 6,2016
     * Description: a program that implements the classes and interfaces
     * version : 0.0.0.11 == FINAL commit
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

        /// <summary>
        /// property for _diameter field
        /// </summary>
        public double Diameter
        {
            get
            {
                return this._diameter;
            }

        }

        /// <summary>
        /// this is a property for _mass field
        /// </summary>
        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        /// <summary>
        /// this is a property for _moonCount field
        /// </summary>
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
        /// <summary>
        /// this is a property for _name field
        /// </summary>

        public string Name
        {
            get
            {
                return this._name;
            }

        }

        /// <summary>
        /// this is a property for _orbitalPeriod field
        /// </summary>
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

        /// <summary>
        /// this is a property for _ringCount field
        /// </summary>
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

        /// <summary>
        /// this is a property for _rotationalPeriod field
        /// </summary>
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
        //~~~~~~=======~~~~~~~~======== constructors
        /*
         * <summary>
         * this constructor takes name, diameter, mass, parameter and passes them to the private var
         * </summary>
         */
        public   Planet(string name,double diameter,double mass) // wehere the vars are assigned
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
          

        }

        /// <summary>
        /// this method Tostring() outputs name, diameter and mass to the console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" || Planet: {0} \n || Diameter: {1}\n || Weights: {2}",this.Name, this.Diameter,this.Mass);
        }
        

        

    }
}
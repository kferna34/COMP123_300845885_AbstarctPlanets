﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_300845885_AbstarctPlanets
{
    /*
     * Author: Krytia Fernandez, 300845885
     * Date Last modified : June 16,2016
     * Description: a program athat implements the classes and interfaces
     * version : 0.0.0.3 -- created all the interfaces and assigned it to its respective classes
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
                throw new System.NotImplementedException();
            }

        }

        public double Mass
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double RotationalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public   Planet(string name,double diameter,double mass)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
        

        

    }
}
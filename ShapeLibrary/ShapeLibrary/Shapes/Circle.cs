﻿using ShapeLibrary.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class Circle:IShape
    {
        public Circle(double radius) 
        {
            if (radius < 0) throw new CircleRadiusShouldBePositiveException();
            Radius = radius; 
        }

        public double Radius { get; }

        public double CalculateArea()
        {
           return Math.PI * Radius*Radius;
        }
    }
}
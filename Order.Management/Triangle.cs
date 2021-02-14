﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        public override string Name => "Triangle";

        public override int Price => 2;

        public Triangle(int numberOfRedTriangles, int numberOfBlueTriangles, int numberOfYellowTriangles)
            : base(numberOfRedTriangles, numberOfBlueTriangles, numberOfYellowTriangles)
        {
        }
    }
}

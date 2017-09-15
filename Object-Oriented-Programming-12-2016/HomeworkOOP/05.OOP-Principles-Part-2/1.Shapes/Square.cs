﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Square : Rectangle
    {
        public Square(double width) 
            : base(width, width)
        {
            
        }


        public override double CalculateSurface()
        {
            return this.Width * this.Width ;
        }
    }
}

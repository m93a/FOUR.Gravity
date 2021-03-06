﻿using MathNet.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathNet.GeometricAlgebra
{
    public class SparseMultivector : Multivector
    {
        
        public SparseMultivector(Space space)
            : base(space, new SparseArray<double>(1 << (int)space.Dimension)) {}
    }
}

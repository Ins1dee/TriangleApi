using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle.Domain.Services.Interfaces;

namespace Triangle.Domain.Services.Implementation
{
    public class TriangleService: ITriangleService
    {
        public double GetPerimeter(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public double GetArea(double firstSide, double secondSide, double thirdSide)
        {
            double p = GetPerimeter(firstSide, secondSide, thirdSide) / 2;

            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Domain.Services.Interfaces
{
    public interface ITriangleService
    {
        public double GetPerimeter(double firstSide, double secondSide, double thirdSide);

        public double GetArea(double firstSide, double secondSide, double thirdSide);
    }
}

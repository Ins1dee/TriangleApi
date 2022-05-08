namespace Triangle.Domain.Services.Interfaces
{
    public interface ITriangleService
    {
        public double GetPerimeter(double firstSide, double secondSide, double thirdSide);

        public double GetArea(double firstSide, double secondSide, double thirdSide);
    }
}

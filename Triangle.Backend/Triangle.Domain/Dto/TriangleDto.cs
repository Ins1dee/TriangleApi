using System.ComponentModel.DataAnnotations;
using Triangle.Domain.CustomAttributes;

namespace Triangle.Domain.Dto
{
    [ValidateTriangle]
    public class TriangleDto
    {
        [Required]
        public double FirstSide { get; set; }

        [Required]
        public double SecondSide { get; set; }

        [Required]
        public double ThirdSide { get; set; }
    }
}

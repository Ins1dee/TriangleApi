using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

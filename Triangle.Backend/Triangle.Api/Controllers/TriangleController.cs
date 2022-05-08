using Microsoft.AspNetCore.Mvc;
using Triangle.Domain.Dto;
using Triangle.Domain.Services.Interfaces;

namespace Triangle.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TriangleController : Controller
    {
        private readonly ITriangleService triangleService;

        public TriangleController(ITriangleService triangleService)
        {
            this.triangleService = triangleService;
        }

        [HttpGet]
        [Route("area")]
        public IActionResult GetArea([FromQuery] TriangleDto triangle)
        {
            return Ok(triangleService.GetArea(triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide));
        }

        [HttpGet]
        [Route("perimeter")]
        public IActionResult GetPerimenter([FromQuery] TriangleDto triangle)
        {
            return Ok(triangleService.GetPerimeter(triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide));
        }
    }
}

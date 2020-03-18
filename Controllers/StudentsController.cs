using Microsoft.AspNetCore.Mvc;

namespace cw3___v2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }
    }
}
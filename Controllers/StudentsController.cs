using Microsoft.AspNetCore.Mvc;

namespace cw3___v2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    { 
        [HttpGet]
        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }
        
        // public 
    }
}
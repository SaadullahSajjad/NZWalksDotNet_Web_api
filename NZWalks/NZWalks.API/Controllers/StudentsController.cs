using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    //my url here will be: https://localhost:portnum/api/students(name of the controller)
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //this function will execute when we come to this url
        //Get: https://localhost:portnum/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Ghufran", "Noman", "David"};
            return Ok(studentNames);
        }

    }
}

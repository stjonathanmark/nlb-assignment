using Microsoft.AspNetCore.Mvc;

namespace NLBAssignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Students = new List<Student>()
                {
                    new() { Name = "Alice", Age = 20, Hobbies = new List<string>  { "reading", "swimming", "coding" } },
                    new() { Name = "Bob", Age = 22, Hobbies = new List<string>  { "painting", "dancing", "singing" } }
                }
            });
        }
    }
}

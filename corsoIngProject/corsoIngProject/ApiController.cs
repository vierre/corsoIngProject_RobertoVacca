using corsoIngProject.Dal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace corsoIngProject
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly IStudentsRepo studentsRepo;

        public ApiController(IStudentsRepo studentsRepo)
        {
            this.studentsRepo = studentsRepo;
        }

        [HttpGet("students")]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await studentsRepo.GetStudents());
        }

        [HttpPut("students")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            return Ok(await studentsRepo.CreateStudent(student));
        }

        [HttpPost("students")]
        public async Task<IActionResult> UpdateStudent([FromBody]Student student)
        {
            await studentsRepo.UpdateStudent(student);
            return Ok();
        }

        [HttpDelete("students")]
        public async Task<IActionResult> DeleteStudent([FromQuery]Guid id)
        {
            await studentsRepo.DeleteStudent(id);
            return Ok();
        }

    }
}

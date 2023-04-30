using Microsoft.AspNetCore.Mvc;
using StepMediaTest.Models;
using StepMediaTest.Services.Interfaces;

namespace StepMediaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IServices _service;

        public ProjectController(ILogger<ProjectController> logger, IServices service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("student")]
        public IActionResult InsertStudent ([FromBody] List<Student> students)
        {
            try
            {
                _service.AddStudents(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPost("teacher")]

        public IActionResult InsertTeacher ([FromBody] List<Teacher> teachers)
        {
            try
            {
                _service.AddTeachers(teachers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult GetModels (Param param)
        {
            return Ok(_service.GetViewModels(param));
        }

        

    }
}
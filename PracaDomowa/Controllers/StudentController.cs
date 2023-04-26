using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracaDomowa.Helpers;
using PracaDomowa.Models;
using PracaDomowa.Repositories;


namespace PracaDomowa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentsRepository _studentsService;


        public StudentController(IStudentsRepository studentsRepository)
        {
            _studentsService = studentsRepository;
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody]Student student)
        {
            var cos = student;
            var id = _studentsService.AddStudent(student);
            return Ok(student);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentsService.GetStudentByID(id);
            if (student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllStudents()
        {
            var students = _studentsService.GetAll();
            return Ok(students);
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            var isSuccess = _studentsService.DeleteStudent(id);

            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }





        [HttpPut("{id:int}")]
        public IActionResult UpdateStudent([FromRoute] int id, [FromBody] StudetHelper student)
        {
            var isSuccess = _studentsService.UpdateStudent(id, student);


           // var isSuccess = true;
            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }



    }
}

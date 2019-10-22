using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using codeWarsAPI.DataAccess;
using codeWarsAPI.Models;
using codeWarsAPI.Services;

namespace codeWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentsController(StudentService service)
        {
            _service = service;
        }

        // GET: api/Students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {

        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {

        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, Student student)
        {
           
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public ActionResult<int> DeleteStudent(int id)
        {

        }
    }
}

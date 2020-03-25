using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_3.DAL;
using Task_3.Models;

namespace Task_3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        [HttpGet("{id}")]

        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2) 
            {
                return Ok("Malewski");
            }
            return NotFound("Nie zanleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            //...add to database
            //...generating index number
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
            if (id > 0)
            {
                return Ok("Update Completed");
            }
            return Forbid("Update Denied");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (id > 0)
            {
                return Ok("Delete Completed");
            }
            else if (id == -666) {
                return Ok("https://www.youtube.com/watch?v=cfKPobjPZSE");
            }
            return Forbid("Delete Denied");
        }
    }
}

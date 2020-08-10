using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentsController : ApiController
    {
        Student[] students = new Student[]
            {
                new Student { Id =1, Name = "Saman Kumara", School = "Royal Collage", GuardianName = "Sampth Kumara"},
                new Student { Id =2, Name = "Summith Ekenayaka", School = "Nalanda Collage", GuardianName = "Viraj Ekenayaka"},
                new Student { Id =3, Name = "Viraj De Silva", School = "Thomas Collage", GuardianName = "Sunil De Silva"}
            };

        [HttpGet]
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        [HttpGet]
        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((s) => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public void myPostmethod()
        {
            Debug.WriteLine("My Post Method is called");
        }
    }
}

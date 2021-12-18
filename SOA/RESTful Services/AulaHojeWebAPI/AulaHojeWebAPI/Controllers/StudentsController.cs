/*
 * RESTful Services
 * WebAPI ASP.NET Core
 * https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-3.1
 * liufer
 * */
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AulaHojeWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {

        static Model.Students students;

        public StudentsController()
        {
            //Initialization
            if (students == null)
            {
                students = new Model.Students();

                students.AddStudent(new Model.Student("one", 1));
                students.AddStudent(new Model.Student("two", 2));
                students.AddStudent(new Model.Student("three", 3));
            }
        }

        /// <summary>
        /// GET RESTful Service
        /// </summary>
        /// <param name="numberStudent"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getStudentName/{numberStudent}")]
        //Students/getStudentName/2
        public string GetStudentName(int numberStudent)
        {
            return students.GetStudentName(numberStudent);
        }

        /// <summary>
        /// GET RESTful Service
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]
        //Students/All
        public IEnumerable<Model.Student> GetAll()
        {
            return students.Course;
        }

        /// <summary>
        /// POST RESTful Service
        /// ActionResult: to support possible "errors"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddStudent")]
        public ActionResult<bool> AddStudent(Model.Student s)
        {
            return students.AddStudent(s);
        }

    }
}

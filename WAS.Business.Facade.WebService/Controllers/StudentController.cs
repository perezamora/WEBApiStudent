using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WAS.Business.Logic;
using WAS.Business.Logic.Exceptions;
using WAS.Common.Logic.Logger;
using WAS.Common.Logic.Model;

namespace WAS.Business.Facade.WebService.Controllers
{
    public class StudentController : ApiController
    {
        private readonly ILogger _log;
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService, ILogger log)
        {
            _studentService = studentService;
            _log = log;
        }

        [HttpGet()]
        public IHttpActionResult Read(int idStudent)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var student = _studentService.GetById(idStudent);
                return Ok(student);
            }
            catch (WasBLException e)
            {
                _log.Debug(e.InnerException);
                return InternalServerError();
            }
        }

        [HttpGet()]
        public IHttpActionResult GetAll()
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var students = _studentService.GetAll();
                return Ok(students);
            }
            catch (WasBLException e)
            {
                _log.Debug(e.InnerException);
                return InternalServerError();
            }
        }

        [HttpPost()]
        public IHttpActionResult Add(Student student)
        {
            try
            {
                var studentAdd = _studentService.Add(student);
                return Ok(studentAdd);
            }
            catch (WasBLException e)
            {
                _log.Debug(e.InnerException);
                return InternalServerError();
            }
        }

        [HttpDelete()]
        public IHttpActionResult Delete(int idStudent)
        {
            try
            {
                var result = _studentService.DeleteById(idStudent);
                return Ok(result);
            }
            catch (WasBLException e)
            {
                _log.Debug(e.InnerException);
                return InternalServerError();
            }
        }

        [HttpPut()]
        public IHttpActionResult Update(int id, Student student)
        {
            try
            {
                var studentUpdate = _studentService.Update(student.Id, student);
                return Ok(studentUpdate);
            }
            catch (WasBLException e)
            {
                _log.Debug(e.InnerException);
                return InternalServerError();
            }
        }

    }
}

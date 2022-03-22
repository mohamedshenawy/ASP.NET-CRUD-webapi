using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using taskDay7.Models;

namespace taskDay7.Controllers
{
    public class HomeController : ApiController
    {
        Context context = new Context();

        [HttpGet]
        public IHttpActionResult  Get()
        {
            var qry = (from s in context.students
                       select s).ToList();
            return Ok <IEnumerable<Student>>(qry);
        }

        [HttpPost]
        public IHttpActionResult add(Student std)
        {
            var students = context.students;
            students.Add(std);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetStudent(int id)
        {
            return Ok<Student>(GetByID(id));
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var std = GetByID(id);
            context.Entry(std).State = EntityState.Deleted;
            context.SaveChanges();
            return Ok();

        }

        [HttpPut]
        public IHttpActionResult Update(int id , Student std)
        {
            var Student = std;
            if (Student.ID != id)
                return NotFound();

            context.Entry(Student).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        private Student GetByID(int id)
        {
           return  (from s in context.students
                      where s.ID == id
                      select s).FirstOrDefault();
           
        }
    }
}

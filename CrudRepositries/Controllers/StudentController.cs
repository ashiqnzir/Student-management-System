using CrudRepositries.Models;
using CrudRepositries.Repositries;
using Microsoft.AspNetCore.Mvc;

namespace CrudRepositries.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepo studentRepoo;
        public StudentController(StudentRepo repoo)
        {
            this.studentRepoo = repoo;
        }
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Submit(Student formdata)
        {
            studentRepoo.AddData(formdata);
            return PartialView("SubmitPartial");
        }
        public IActionResult ViewDetails()
        {
            var obj = studentRepoo.Viewdetails();
            return View(obj);
        }

        public IActionResult ViewAllDetails(int id)
        {
            Student obj = studentRepoo.ViewAllDetails(id);
            return View(obj);
        }
        public IActionResult Delete(int id)
        {
            studentRepoo.DeleteRecord(id);
            return RedirectToAction("ViewDetails");
        }

        public IActionResult Edit(int id)
        {
            Student obj = studentRepoo.Editt(id);
            return View(obj);
        }
        public IActionResult Update(Student formdata)
        {
            studentRepoo.Update(formdata);
            return RedirectToAction("ViewDetails");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVC_Project.Context;
using MVC_Project.Models;
using MVC_Project.Services;

namespace MVC_Project.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;
        public SubjectController(ISubjectServices _iss) 
        {
            iss = _iss;
        }

        public IActionResult Index()
        {
            
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id) 
        { 
             
            iss.DeleteASubject(id);
             return RedirectToAction("Index");
              

        }

    }
        
}


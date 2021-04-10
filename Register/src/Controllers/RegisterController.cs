/************************************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Controller function: Controller used to save the information of a new student  
 * or teacher in the system.
 * Company: WIS - NZ
 * */

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RegisterWebApp.Models;
using System;
using System.Threading.Tasks;


namespace RegisterWebApp.Controllers
{

    public class RegisterController : Controller
    {
        private readonly CIContext _context;
        private IConfiguration _config;
        public RegisterController(CIContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
        }
        //Home page
        public IActionResult Default()
        {

            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            ViewBag.Home_Register = _url;
            return View();
        }

        // GET: Students/Create
        // Method used to show the form with the fields to be
        // filled out to the student.
        public IActionResult CreateS()
        {
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            ViewBag.Home_Register = _url;
            return View();
        }

        // POST: Students/Create
        // Method used to validate the information of the student and 
        // register it in the database. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateS([Bind("IdStudent,FullName,IdNumber,Email,Pass,Password1")] Student student)
        {
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                Response.Redirect("Default");
            }
            return View(student);
        }

        // GET: Teacher/Create
        // Method used to show the form with the fields to be
        // filled out to the teacher.
        public IActionResult CreateT()
        {
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            ViewData["Home_Register"] = _url;
            return View();
        }

        // POST: Teacher/Create
        // Method used to validate the information of the teacher and 
        // register it in the database. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateT([Bind("IdTeacher,FullName,IdNumber,Email,Pass")] Teacher teacher)
        {
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            
            if (ModelState.IsValid)
            {
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                Response.Redirect("Default");
            }
            return View(teacher);
        }


    }
}
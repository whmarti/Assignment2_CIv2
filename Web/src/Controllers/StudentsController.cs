/************************************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Controller function: Controller used to save the information of a new student in the system.
 * Company: WIS - NZ
 * */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnivWebApp.Models;

namespace UnivWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly CIContext _context;

        public StudentsController(CIContext context)
        {
            _context = context;
        }

       
        // Method used to display existing students in the database.
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        //Home page
        public IActionResult Default()
        {
            int? _id = HttpContext.Request.Query["id"].ToString()!= null ? Convert.ToInt32(HttpContext.Request.Query["id"]) : 0;
            if (_id >0)
            {

                using (_context)
                {
                    Student student =  _context.Student.FirstOrDefault(m => m.IdStudent == _id);
                    if (student != null)
                    {
                        ViewData["W_Person"] = "Welcome " + student.FullName.Trim();
                    }
                }
            }
            return View();
        }

        // GET: Students/Details/5
      
    }
}

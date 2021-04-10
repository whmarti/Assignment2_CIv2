/************************************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Controller function: Controller used to save the information of a new teacher  
 * in the system.
 * Company: WIS - NZ
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UnivWebApp.Models;

namespace UnivWebApp.Controllers
{
    public class TeachersController : Controller
    {
        private readonly CIContext _context;
        public TeachersController(CIContext context)
        {
            _context = context;
        }

        // Method used to display existing teachers in the database.
        public async Task <IActionResult> Index()
        {
            return View(await _context.Teacher.ToListAsync());
        }

        //Home page
        public IActionResult Default()
        {
            int? _id = HttpContext.Request.Query["id"].ToString() != null ? Convert.ToInt32(HttpContext.Request.Query["id"]) : 0;
            if (_id > 0)
            {

                using (_context)
                {
                    Teacher teacher = _context.Teacher.FirstOrDefault(m => m.IdTeacher == _id);
                    if (teacher != null)
                    {
                        ViewData["W_Person"] = "Welcome Proffesor " + teacher.FullName.Trim();
                    }
                }
            }
            return View();
        }

       
    }
}
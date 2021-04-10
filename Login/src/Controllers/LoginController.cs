/************************************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Controller function: Controller used to validate the security credentials of a current student  
 * or teacher in the system.
 * Company: WIS - NZ
 * */
using LoginWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace LoginWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly CIContext _context;         
        private IConfiguration _config;
        public LoginController(CIContext context, IConfiguration  config)
        {
            _config = config;           
            _context = context;
        }
        //Home page
        public IActionResult Default()
        {
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            ViewData["Home_Login"] = _url;
            return View();
        }

        // POST: Students/Create
        // Method used to validate the information of the student or teacher  
        // in the database. 
        [HttpPost]
        [ValidateAntiForgeryToken]    
        public  IActionResult Default([Bind("Email,Pass,TypeL")] Login user)
        {
            int _idU = 0;
            String _url = _config.GetValue<string>("AppSettings:WebSite").ToString();
            
            if (ModelState.IsValid)
            {
                ViewData["res"] = "";
                using (_context)
                {
                    if (user.TypeL.Trim() == "Student")
                    {
                        var student = _context.Student.FirstOrDefault(m => m.Email == user.Email.Trim() && m.Pass == user.Pass.Trim());
                        _idU = student != null ? student.IdStudent : 0;
                    }
                    else
                    {
                        var teacher =  _context.Teacher
                          .FirstOrDefault(m => m.Email == user.Email.Trim() && m.Pass == user.Pass.Trim());
                        _idU = teacher != null ? teacher.IdTeacher : 0;
                    }
                }
                if (user != null && _idU > 0)
                {                    
                    String _web = user.TypeL.Trim() == "Student" ? (_url + "Students/" + "Default?id=" + _idU) : (_url + "Teachers/" + "Default?id=" + _idU);
                    Response.Redirect(_web);
                }
            }
            ViewData["res"]="User does not exist, try again..";
           
            return View(user);
        }



    }
}
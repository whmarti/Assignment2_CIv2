
/****************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Controller function: Controller used to allow the user to review informational 
 * content about the university, the programs it offers, as well as to register to the
 * system or log in (as Student or Professor) and manage a set of functionalities 
 * according to their role. These can be to see the student's schedules, the subjects 
 * in which he is enrolled, etc, or see the list of students that belong to the 
 * courses he dictates, place the notes, etc.
 * Company: WIS - NZ
 * */
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using UnivWebApp.Models;

namespace UnivWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
       
        public HomeController( IConfiguration config) 
        {           
            _config = config;          
        }
        //Home page
        // Method that displays the welcome interface to the visiting user.
        public IActionResult Index()
        {
            String _url = _config.GetValue<string>("AppSettings:LogSite").ToString();
            ViewBag.Home_Login = _url;
            _url = _config.GetValue<string>("AppSettings:RegSite").ToString();
            ViewBag.Home_Register = _url;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

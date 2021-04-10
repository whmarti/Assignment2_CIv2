/****************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Class function: Class used to manage the information of the 
 * Teacher table.
 * Company: WIS - NZ
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginWebApp.Models
{
    public partial class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}

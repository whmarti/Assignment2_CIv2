/****************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Class function: Class used to manage the information of the 
 * user credentials (Student/Teacher).
 * Company: WIS - NZ
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnivWebApp.Models
{
    public class Login
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "The User name is required.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "The User name must have more than 6 characters and less than 16.")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Insert a correct email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The password must have more than 2 characters and less than 21.")]
        //[DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
        [Display(Name = "Access as:")]
        public string TypeL { get; set; }
    }
}

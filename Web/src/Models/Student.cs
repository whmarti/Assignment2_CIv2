/****************************************************************
 * Developer: William Martin
 * Date creation: 03/09/2021
 * Class function: Class used to manage the information of the 
 * Student table.
 * Company: WIS - NZ
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnivWebApp.Models
{
    public partial class Student
    {
        [Key]
        public int IdStudent { get; set; }

        [Required (ErrorMessage ="The full name is required." )]
        [StringLength(100, MinimumLength=3,  ErrorMessage = "The full name must have more than 2 characters and less than 101.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required (ErrorMessage = "The full Id Number is required.")]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "The full Id Number must have more than 6 characters and less than 16.")]
       
        [Display(Name = "Id Number")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "Insert a correct Id Number.")]
        private string idNumber { get; set; }
        public string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value.Trim(); }
        }

        [Display(Name = "E-Mail")]
        [Required (ErrorMessage = "The E-Mail is required.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "The E-Mail must have more than 6 characters and less than 16.")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Insert a correct email.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "The password is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The password must have more than 2 characters and less than 21.")]
        //[DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
    }
}

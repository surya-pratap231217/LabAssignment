using System.ComponentModel.DataAnnotations;

namespace SecondProject.Models
{
    public class UserViewModel
    {
        [Required (ErrorMessage ="Please Enter your Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter your mail")]
        [EmailAddress(ErrorMessage ="Please Enter Correct Mail")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter the Password")]
        public string Password { get; set; }
        [Compare(Password,ErrorMessage ="Confirm Password doesn't match")]
        public string Confirm_Password {get; set;}
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage ="Please enter correct Phone_NO")]
        public string Phone_no {get; set;}
        [Required(ErrorMessage ="Please accept the terms")]
        public bool IsTerm { get; set;}
    }
}

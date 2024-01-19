using System.ComponentModel.DataAnnotations;

namespace Vendor_Review_System.Models
{
    public class FoodieModel
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[A-z]{1}[a-z]{4}[@#$%^&*]{1}[0-9]{3}")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailID { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        
        
        public int Age { get; set; }

        [Required]
        public string MobileNo { get; set; }
    }
}

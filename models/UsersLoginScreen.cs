using System.ComponentModel.DataAnnotations;

namespace Vendor_Review_System.Models
{
    public class UsersLoginScreen
    {
        [Required]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

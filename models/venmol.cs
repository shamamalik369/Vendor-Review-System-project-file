using System.ComponentModel.DataAnnotations;

namespace Vendor_Review_System.Models
{
    public class venmol
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailID { get; set; }

        [Required]
        public string WebsiteID { get; set; }

        [Required]
        public string Location { get; set; }
    }
}

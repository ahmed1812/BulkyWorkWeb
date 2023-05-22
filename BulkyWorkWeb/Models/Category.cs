using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWorkWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        public string Address { get; set; }
		[DisplayName("Job Titel")]
		public string JobTitel { get; set; }
        public DateTime DateOfSubmit { get; set; } = DateTime.Now;
		[DisplayName("Phone Inter View")]
		public string PhoneInterView { get; set; }
		[DisplayName("Video Inter View")]
		public string VideoInterView { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}

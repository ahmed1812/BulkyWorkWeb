using System.ComponentModel.DataAnnotations;

namespace BulkyWorkWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string JobTitel { get; set; }
        public DateTime DateOfSubmit { get; set; } = DateTime.Now;
        public string PhoneInterView { get; set; }
        public string VideoInterView { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}

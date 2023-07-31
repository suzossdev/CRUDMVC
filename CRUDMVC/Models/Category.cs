using System.ComponentModel.DataAnnotations;

namespace CRUDMVC.Models
{
    public class Category
    {
        [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}

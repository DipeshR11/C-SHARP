using System.ComponentModel.DataAnnotations;

namespace WebAppp.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Category Name")]

        public string? Name { get; set; }

        [Required(ErrorMessage = "Enter Description")]

        public string? Description { get; set; }
    }
}

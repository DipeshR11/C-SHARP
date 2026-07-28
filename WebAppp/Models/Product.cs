using System.ComponentModel.DataAnnotations;

namespace WebAppp.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Product Name")]
        [StringLength(20, ErrorMessage = "Product name cannot exceed 20 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please provide Description")]
        [StringLength(500, ErrorMessage = "Description should not exceed 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter Price")]
        [Range(1, 1000, ErrorMessage = "Price must be 1-1000.")]
        public int Price { get; set; }

    }
}
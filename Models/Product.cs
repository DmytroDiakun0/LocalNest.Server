using System.ComponentModel.DataAnnotations;

namespace LocalNest.Server.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Image_URL { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
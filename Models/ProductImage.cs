using System.ComponentModel.DataAnnotations;

namespace VnkDecor.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        // Khóa ngoại liên kết với Product
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnkDecor.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        // Điều hướng
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}

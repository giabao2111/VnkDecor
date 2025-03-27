using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnkDecor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }
        public string Address { get; set; }
        public string Style { get; set; }
        public string CustomerName { get; set; }
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Description { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    }
}

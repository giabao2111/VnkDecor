using System.ComponentModel.DataAnnotations;

namespace VnkDecor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
    }
}

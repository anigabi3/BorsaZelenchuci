using System.ComponentModel.DataAnnotations;

namespace BorsaZaZelenchutsiSvejest.Data
{
    public class TypeProduct
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}

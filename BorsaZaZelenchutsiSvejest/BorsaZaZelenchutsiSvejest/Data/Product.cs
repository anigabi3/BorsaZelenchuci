using System.ComponentModel.DataAnnotations.Schema;

namespace BorsaZaZelenchutsiSvejest.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeProductsId {  get; set; }
        public TypeProduct TypeProducts { get; set; }
        public string CatalogNumber { get; set; }
        public string ImageURL {  get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; } 
        public DateTime DateCreated { get; set; }
        public ICollection<Order> Orders { get; set;}

    }
}

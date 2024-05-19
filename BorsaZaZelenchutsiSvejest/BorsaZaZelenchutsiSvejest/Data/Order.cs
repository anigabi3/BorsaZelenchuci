namespace BorsaZaZelenchutsiSvejest.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientsId { get; set; }
        public Client Clients { get; set; }
        public int ProductsId {  get; set; }
        public Product Products { get; set; }
        public int Quantity {  get; set; }
        public DateTime OrderOn { get; set; }= DateTime.Now;
    }
}

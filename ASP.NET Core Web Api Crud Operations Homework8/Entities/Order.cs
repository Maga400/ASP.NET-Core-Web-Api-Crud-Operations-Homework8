namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}

namespace CarPriceApi.CarPriceApi.Crawler.Models
{
    public class ProductModel : AuditLogModel
    {
        public string ProductName { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public string LinkDetail { get; set; }
    }
}

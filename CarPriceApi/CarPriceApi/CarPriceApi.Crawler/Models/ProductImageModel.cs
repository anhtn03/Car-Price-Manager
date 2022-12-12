namespace CarPriceApi.CarPriceApi.Crawler.Models
{
    public class ProductImageModel: AuditLogModel
    {
        public Guid ProductId { get; set; }

        public string LinkImage { get; set; }

        public string LocalPathImage { get; set; }
    }
}

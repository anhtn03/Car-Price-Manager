namespace CarPriceApi.CarPriceApi.Crawler.Models
{
    public class ProductInforAllModel
    {
        public ProductInforAllModel()
        {
            ListProduct = new List<ProductModel>();
            ListImageProduct = new List<ProductImageModel>();
            ListAuditLog = new List<AuditLogModel>();
        }

        public List<ProductModel> ListProduct { get; set; }

        public List<ProductImageModel> ListImageProduct { get; set; }

        public List<AuditLogModel> ListAuditLog { get; set; }
    }
}

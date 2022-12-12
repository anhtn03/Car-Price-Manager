namespace CarPriceApi.CarPriceApi.Crawler.Models
{
    public class AuditLogModel
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdateBy { get; set; }

        public DateTime UpdatedAt { get; set;}
    }
}

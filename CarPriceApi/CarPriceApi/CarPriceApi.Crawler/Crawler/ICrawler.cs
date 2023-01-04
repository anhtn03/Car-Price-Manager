using CarPriceApi.CarPriceApi.Crawler.Models;
using System.Collections;

namespace CarPriceApi.CarPriceApi.Crawler.Crawler
{
    public interface ICrawler
    {
        public Task<ProductInforAllModel> Crawling(CancellationToken cancellationToken);

        public Task<List<ProductModel>> CrawProductDetail(CancellationToken cancellationToken);

        public Task<List<ProductImageModel>> CrawProductImage(CancellationToken cancellationToken);
    }
}

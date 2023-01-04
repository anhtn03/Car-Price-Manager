using CarPriceApi.CarPriceApi.Crawler.Models;
using System.Collections;

namespace CarPriceApi.CarPriceApi.Crawler.Crawler
{
    public class Crawler : ICrawler
    {
        public Task Crawling(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> CrawProductDetail(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductImageModel>> CrawProductImage(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<ProductInforAllModel> ICrawler.Crawling(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

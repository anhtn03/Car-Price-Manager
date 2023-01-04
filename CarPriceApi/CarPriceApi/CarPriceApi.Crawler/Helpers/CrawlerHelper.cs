using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace CarPriceApi.CarPriceApi.Crawler.Helpers
{
    public static class CrawlerHelper
    {
        public static HtmlNode GetPrice(HtmlDocument document, string querySelector) 
        {
            if(string.IsNullOrEmpty(querySelector))
            {
                throw new ArgumentNullException("Price Query Selector is invalid");
            }

            var node = document
                .DocumentNode
                .QuerySelector(querySelector);

            return node;
        }

        public static List<HtmlNode> GetMultiElement(HtmlDocument document, string querySelector) 
        {
            if(string.IsNullOrEmpty(querySelector))
            {
                throw new ArgumentNullException("multi element Query Selector is invalid");
            }

            var node = document
                .DocumentNode
                .QuerySelectorAll(querySelector)
                .ToList();

            return node;
        }


    }
}

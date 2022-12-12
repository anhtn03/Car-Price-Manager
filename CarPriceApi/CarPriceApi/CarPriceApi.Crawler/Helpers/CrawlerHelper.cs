using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace CarPriceApi.CarPriceApi.Crawler.Helpers
{
    public static class CrawlerHelper
    {
        public static HtmlNode GetPrice(HtmlDocument document, string querySelector) 
        {
            var node = document
                .DocumentNode
                .QuerySelector(querySelector);

            return node;
        }

        public static List<HtmlNode> GetMutiNote(HtmlDocument document, string querySelector) 
        {
            var node = document
                .DocumentNode
                .QuerySelectorAll(querySelector)
                .ToList();

            return node;
        }
    }
}

using GeoSearcher.YandexMapsApi.Responses.SearchResultDtos;

namespace GeoSearcher.YandexMapsApi.Responses
{
    public class YandexMapsSearchResult
    {
        public string Type { get; set; }
        public SearchResultProps Properties { get; set; }
        public Feature[] Features { get; set; }
    }
}
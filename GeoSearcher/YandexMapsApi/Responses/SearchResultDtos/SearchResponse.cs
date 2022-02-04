using System.Collections.Generic;

namespace GeoSearcher.YandexMapsApi.Responses.SearchResultDtos
{
    public class SearchResponse
    {
        public int Found { get; set; }
        public MapObject Point { get; set; }
        public List<double[]> BoundedBy { get; set; }
        public string Display { get; set; }
    }
}
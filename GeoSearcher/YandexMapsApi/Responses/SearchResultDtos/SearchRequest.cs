using System.Collections.Generic;

namespace GeoSearcher.YandexMapsApi.Responses.SearchResultDtos
{
    public class SearchRequest
    {
        public string Request { get; set; }
        public int Results { get; set; }
        public int Skip { get; set; }
        public List<double[]> BoundedBy { get; set; }
    }
}
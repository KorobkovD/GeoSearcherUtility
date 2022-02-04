using System.Collections.Generic;

namespace GeoSearcher.YandexMapsApi.Responses.SearchResultDtos
{
    public class FeatureProps
    {
        public GeocoderMetaData GeocoderMetaData { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public List<double[]> BoundedBy { get; set; }
    }
}
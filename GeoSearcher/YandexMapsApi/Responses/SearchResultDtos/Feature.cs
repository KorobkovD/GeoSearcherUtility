namespace GeoSearcher.YandexMapsApi.Responses.SearchResultDtos
{
    public class Feature
    {
        public string Type { get; set; }
        public FeatureProps Properties { get; set; }
        public MapObject Geometry { get; set; }
    }
}
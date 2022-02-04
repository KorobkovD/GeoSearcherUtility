using Refit;

namespace GeoSearcher.YandexMapsApi.Requests
{
    public class YandexQueryParams
    {
        public string ApiKey { get; set; }
        public string Text { get; set; }
        public string Lang { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Coordinates of center of searching area (lon,lat)
        /// </summary>
        [AliasAs("ll")]
        public string CenterCoordinates { get; set; }

        public string Spn { get; set; }
        public string Rspn { get; set; }
    }
}
using Refit;

namespace GeoSearcher.YandexMapsApi.Requests
{
    public class YandexQueryParams
    {
        [AliasAs("apikey")]
        public string ApiKey { get; set; }

        [AliasAs("text")]
        public string Text { get; set; }

        [AliasAs("lang")]
        public string Lang { get; set; }

        [AliasAs("type")]
        public string Type { get; set; }

        /// <summary>
        /// Coordinates of center of searching area (lon,lat)
        /// </summary>
        [AliasAs("ll")]
        public string CenterCoordinates { get; set; }

        [AliasAs("spn")]
        public string Spn { get; set; }

        [AliasAs("rspn")]
        public int Rspn { get; set; }
    }
}
using GeoSearcher.YandexMapsApi.Requests;
using GeoSearcher.YandexMapsApi.Responses;
using Refit;

namespace GeoSearcher.YandexMapsApi
{
    public interface IYandexMapsApi
    {
        [Get("/v1")]
        public YandexMapsSearchResult Search(YandexQueryParams queryParams);
    }
}
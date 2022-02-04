using System;
using System.Linq;
using System.Threading.Tasks;
using GeoSearcher.YandexMapsApi;
using GeoSearcher.YandexMapsApi.Requests;
using Refit;

namespace GeoSearcher
{
    internal static class Program
    {
        private static string _apiKey;
        private static MapSource _mapSource;
        /// <summary>
        /// Координаты центра зоны поиска (lon,lat)
        /// </summary>
        private static string _centerCoords;
        
        static async Task Main(string[] args)
        {
            ReadCommandLineArgumentsPairs(args);
            
            // TODO: реализовать фабрику поиска через google и yandex api
            var ymapi = RestService.For<IYandexMapsApi>("https://search-maps.yandex.ru");
            var queryParams = new YandexQueryParams
            {
                Lang = "RU",
                Type = "geo",
                CenterCoordinates = _centerCoords,
                Rspn = 1,
                Spn = "1,1",
                ApiKey = _apiKey
            };

            var queryText = GetQueryTextFromConsole();
            while (queryText != "/q")
            {
                queryParams.Text = queryText;
                var result = await ymapi.Search(queryParams);

                var relevantObject = result.Features
                                           .FirstOrDefault(x => x.Properties.GeocoderMetaData.Kind == "locality");
                var name = relevantObject?.Properties.GeocoderMetaData.Text;
                var coords = string.Join(' ', relevantObject?.Geometry.Coordinates);
                
                Console.WriteLine($"Results: {result.Properties.ResponseMetaData.SearchResponse.Found}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Coords: {coords}");
                queryText = GetQueryTextFromConsole();
            }
        }

        private static string GetQueryTextFromConsole()
        {
            Console.WriteLine("Enter query: ");
            var queryText = Console.ReadLine();
            return queryText;
        }
        
        /// <summary>
        /// Попарное чтение аргументов запуска утилиты
        /// </summary>
        /// <param name="args">Аргументы</param>
        private static void ReadCommandLineArgumentsPairs(string[] args)
        {
            while (true)
            {
                if (args.Length < 2)
                {
                    return;
                }

                var firstCommand = args[0];
                switch (firstCommand)
                {
                    case ArgumentConstants.YandexMapSourceKey:
                        _apiKey = args[1];
                        _mapSource = MapSource.Yandex;
                        break;
                    
                    case ArgumentConstants.GoogleMapSourceKey:
                        _apiKey = args[1];
                        _mapSource = MapSource.Google;
                        break;
                    
                    case ArgumentConstants.CoordinatesKey:
                        _centerCoords = args[1];
                        break;
                }

                if (args.Length >= 4)
                {
                    args = args[2..];
                    continue;
                }

                break;
            }
        }
    }
}
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
        
        static void Main(string[] args)
        {
            ReadCommandLineArgumentsPairs(args);
            
            // TODO: реализовать фабрику поиска через google и yandex api
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
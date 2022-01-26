using Microsoft.Extensions.Configuration;
using System.IO;

namespace CSharp.CommonUtilities
{
    public class AppSettings
    {        
        /// <summary>
        /// Reads appsettings json file and returns IConfiguration object
        /// </summary>
        /// <param name="path">where appsettings.json or any other json configuration file present</param>
        /// <param name="jsonFileName">configuration file name, default appsettings.json</param>
        /// <returns></returns>
        public static IConfigurationRoot ReadAppSettings(string path, string jsonFileName)
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path1 = Path.Combine(path, jsonFileName);
            configurationBuilder.AddJsonFile(path1, false);

            var root = configurationBuilder.Build();
            return root;
        }
    }
}

using Microsoft.Extensions.Configuration;
using System.IO;

namespace Common
{
    public class AppSettings
    {
        public static IConfigurationRoot Root
        {
            get
            {
                var configurationBuilder = new ConfigurationBuilder();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                configurationBuilder.AddJsonFile(path, false);

                var root = configurationBuilder.Build();
                return root;
            }
        }
    }
}

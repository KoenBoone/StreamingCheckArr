using Microsoft.Extensions.Configuration;
using StreamingCheckArr.Core.Models;

namespace Core
{
    public class Settings
    {
        private IConfigurationRoot config;

        public Settings()
        {

            var basePath = AppContext.BaseDirectory; // This ensures the path works regardless of the running project
            var jsonPath = Path.Combine(basePath, "appsettings.json");

            //check if the appsettings.json file exists, and if not, create it by copying the appsettings.json.example file
            if (!File.Exists(jsonPath))
            {
                //File.Copy("appsettings.json.example", "appsettings.json");
                throw new FileNotFoundException("appsettings.json file not found. Please create it by copying the appsettings.json.example file.");
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            config = builder.Build();
        }

        public IConfigurationRoot getConfig() 
        {
            return config;
        }
    }
}

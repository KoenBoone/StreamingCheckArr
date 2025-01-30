using Microsoft.Extensions.Configuration;

namespace Core
{
    public class Settings
    {
        private IConfigurationRoot config;

        public string SonarrUrl { get; private set; }
        public string RadarrUrl { get; private set; }

        public Settings()
        {
            //check if the appsettings.json file exists, and if not, create it by copying the appsettings.json.example file
            if (!File.Exists("appsettings.json"))
            {
                //File.Copy("appsettings.json.example", "appsettings.json");
                throw new FileNotFoundException("appsettings.json file not found. Please create it by copying the appsettings.json.example file.");
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            config = builder.Build();

            var a = config.GetSection("SonarrUrl");
        }

        public IConfigurationRoot getConfig()
        {
            return config;
        }
    }
}

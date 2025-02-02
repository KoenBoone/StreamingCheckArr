using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Microsoft.Extensions.Configuration;

namespace StreamingCheckArr.Core.Models
{
    public class configParameters
    {
        public string SonarrUrl { get; private set; }
        public string RadarrUrl { get; private set; }
        public string SonarrApiKey { get; private set; }
        public string RadarrApiKey { get; private set; }
        public string TraktClientId { get; private set; }
        public string TraktClientSecret { get; private set; }
        public string TMDBApi { get; private set; }
        public string TMDBToken { get; private set; }
        public string CountryCode { get; private set; }

        //explicit constructor
        public configParameters()
        {
            Settings settings = new Settings();
            IConfigurationRoot iConf = settings.getConfig();

            SonarrUrl = iConf.GetSection("AppSettings:SonarrUrl").Value;
            RadarrUrl = iConf.GetSection("AppSettings:RadarrUrl").Value;
            SonarrApiKey = iConf.GetSection("AppSettings:SonarrApi").Value;
            RadarrApiKey = iConf.GetSection("AppSettings:RadarrApi").Value;
            TraktClientId = iConf.GetSection("AppSettings:TraktClientId").Value;
            TraktClientSecret = iConf.GetSection("AppSettings:TraktClientSecret").Value;
            TMDBApi = iConf.GetSection("AppSettings:TMDBApi").Value;
            TMDBToken = iConf.GetSection("AppSettings:TMDBToken").Value;
            CountryCode = iConf.GetSection("AppSettings:CountryCode").Value;
        }
    }
}

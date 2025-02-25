using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class StreamerFilter
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }
        public string CountryCode { get; set; }
        public string Type { get; set; }

        public StreamerFilter(string name, string logoPath, string countryCode, string type)
        {
            Name = name;
            LogoPath = logoPath;
            CountryCode = countryCode;
            Type = type;
        }
    }
}

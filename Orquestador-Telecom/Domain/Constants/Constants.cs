using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Orquestador_Telecom.Domain.Constants
{
    public class Constants
    {
        public static string GetURL(string servicio)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");

            IConfigurationRoot configuration = builder.Build();
            string server = configuration[servicio];
            return Environment.GetEnvironmentVariable(server);
        }
        public static string urlInformacionComercial = GetURL("URL_InformacionComercial");
        public static string urlDTB = GetURL("URL_DTB");
    }
}

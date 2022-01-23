using Microsoft.Extensions.Configuration;

namespace Proptech.Core.Helpers
{
    public static class ConfigHelper
    {
        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}

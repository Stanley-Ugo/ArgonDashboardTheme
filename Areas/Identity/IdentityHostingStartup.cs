using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ArgonDashboardTheme.Areas.Identity.IdentityHostingStartup))]
namespace ArgonDashboardTheme.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
namespace Scheduler_Views
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDUxMDk0QDMxMzkyZTMxMmUzMEpVYndyMjhaUlpVN1M5N2ZlcUhvVy9yZ1JBOWovK2NxM0l5OWtNVGxKcFE9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}

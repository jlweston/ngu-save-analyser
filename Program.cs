using Microsoft.AspNetCore.Blazor.Hosting;

namespace NGUSaveAnalyser
{
    public class Program
    {
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder() =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}

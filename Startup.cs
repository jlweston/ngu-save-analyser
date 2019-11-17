using Microsoft.AspNetCore.Components.Builder;

namespace NGUSaveAnalyser
{
    public class Startup
    {
        public void ConfigureServices()
        {
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace MindBehind.InterviewTest
{
    public class Startup
    {
        private const string HeaderMbCount = "MB_COUNT";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<InterviewTestHttpApiHostModule>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {

            app.Use(async (context, next) =>
            {
                StringValues mbCount;
                if (context.Request.Headers.TryGetValue(HeaderMbCount, out mbCount))
                {
                    int mbCountInt;
                    if (int.TryParse(mbCount.ToString(), out mbCountInt))
                    {
                        context.Response.Headers[HeaderMbCount] = (mbCountInt + 1).ToString();
                    }
                }

                await next();
            });

            app.InitializeApplication();
        }
    }
}

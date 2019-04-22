using FGODex.Application.Contract.Client;
using FGODex.Application.Contract.Service;
using FGODex.Application.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FGODex.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddBotBackgroundServices(this IServiceCollection services, IConfiguration configuration, IHostingEnvironment env)
        {
            //services.AddSingleton<IBotClient, BotClient>();

            //services.AddScoped<IBotService, BotService>();

            //services.AddSingleton<IHostedService, Telegram>
            return null;
        }
    }
}

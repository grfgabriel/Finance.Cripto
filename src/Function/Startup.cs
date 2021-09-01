using System;
using Function.Injection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Function.Startup))]
namespace Function
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AdicionarMediatR();
            builder.Services.AdicionarRepositorio();
        }
    }
}

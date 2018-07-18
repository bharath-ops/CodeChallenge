using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using ResistanceCalculator.Web.App_Start;
using ResistanceCalculator.Shared;
using ResistanceCalculator.Service;
using ResistanceCalculator.Web.Controllers;

[assembly: OwinStartup(typeof(ResistanceCalculator.Web.Startup))]

namespace ResistanceCalculator.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());

            DependencyResolver.SetResolver(resolver);
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IOhmValueCalculator,OhmCalculator>();
            serviceCollection.AddTransient<HomeController, HomeController>();
        }
    }

   
}

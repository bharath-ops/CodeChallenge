using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ResistanceCalculator.Web.App_Start
{
    public class DefaultDependencyResolver : IDependencyResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public DefaultDependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetService(Type serviceType)
        {
            return _serviceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceProvider.GetServices(serviceType);
        }
    
    }
}
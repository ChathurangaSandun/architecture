using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace architecture.Infastructure
{
    public class WeatherDependencyResolver : IDependencyResolver
    {

        private readonly IUnityContainer _unityContainer;
        public WeatherDependencyResolver(IUnityContainer container)
        {
            _unityContainer = container;
        }


        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception e)
            {
                return new List<object>();
            }

        }
    }
}
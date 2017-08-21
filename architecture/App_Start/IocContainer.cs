using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using architecture.Infastructure;
using architecture.Service;
using Microsoft.Practices.Unity;

namespace architecture.App_Start
{
    public static  class IocContainer
    {
        public static void ConfigureIocContainer()
        {
            IUnityContainer container = new UnityContainer();

            RegisterServices(container);

            DependencyResolver.SetResolver(new WeatherDependencyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<ILocalWeatherService, LocalWeatherService>();
            container.RegisterType<IFaceBookManager, FacebookManager>(new InjectionConstructor("sandun","123456789"));
        }
    }
}
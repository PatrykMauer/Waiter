using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls;
using Waiter.Repositories;
using Waiter.Services;

namespace Waiter
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<InMemoryDishRepository>().As<IDishRepository>();
            builder.RegisterType<InMemoryTableRepository>().As<ITableRepository>();
            builder.RegisterType<InMemoryOrderRepository>().As <IOrderRepository>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<TableService>().As<ITableService>();
            builder.RegisterType<DishService>().As<IDishService>();


            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Controller"));

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using WAS.Business.Logic;
using WAS.Business.Logic.Autofac;
using WAS.Common.Logic.Logger;

namespace WAS.Business.Facade.WebService.App_Start
{
    public class WebApiIocModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ALog4NetLogger>()
                .As<ILogger>()
                .InstancePerRequest();

            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .InstancePerRequest();

            builder.RegisterModule(new BusinessIocModule());

            base.Load(builder);
        }

    }
}
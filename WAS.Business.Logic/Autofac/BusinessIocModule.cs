using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WAS.Common.Logic.Logger;
using WAS.DataAcces.Dao;
using WAS.DataAcces.Dao.Autofac;

namespace WAS.Business.Logic.Autofac
{
    public class BusinessIocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ALog4NetLogger>()
            .As<ILogger>()
            .InstancePerRequest();

            builder.RegisterGeneric(typeof(StudentRepository<>))
            .As(typeof(IStudentRepository<>));

            builder.RegisterModule(new DataAccesIocModule());

            base.Load(builder);
        }
    }
}

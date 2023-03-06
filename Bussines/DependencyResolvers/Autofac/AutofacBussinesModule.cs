using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussines.Abstract;
using Bussines.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<BookManager>().As<IBooksService>().SingleInstance();
            builder.RegisterType<EfBooksDal>().As<IBooksDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

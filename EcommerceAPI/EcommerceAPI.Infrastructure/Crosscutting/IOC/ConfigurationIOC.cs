using Autofac;
using EcommerceAPI.Application;
using EcommerceAPI.Application.Interfaces;
using EcommerceAPI.Application.Mappers.Interfaces;
using EcommerceAPI.Application.Mappers.Mapper;
using EcommerceAPI.Core.Interfaces.Repositories;
using EcommerceAPI.Core.Interfaces.Services;
using EcommerceAPI.Domain.Services;
using EcommerceAPI.Infrastructure.Data.Repositories;

namespace EcommerceAPI.Infrastructure.Crosscutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceUser>().As<IApplicationServiceUser>();

            builder.RegisterType<ServiceUser>().As<IServiceUser>();

            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            builder.RegisterType<MapperUser>().As<IMapperUser>();

            #endregion IOC
        }
    }
}
using Autofac;
using System.Reflection;
using TunahanAliOzturk.Caching;
using TunahanAliOzturk.Core.Repositories;
using TunahanAliOzturk.Core.Services;
using TunahanAliOzturk.Core.UnitOfWorks;
using TunahanAliOzturk.Repository;
using TunahanAliOzturk.Repository.Repositories;
using TunahanAliOzturk.Repository.UnitOfWorks;
using TunahanAliOzturk.Service.Mapping;
using TunahanAliOzturk.Service.Services;
using Module = Autofac.Module;

namespace TunahanAliOzturk.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();




            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));




            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();












        }
    }
}

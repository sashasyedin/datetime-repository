using Autofac;
using DateTimeRepository.Abstractions;
using DateTimeRepository.Example.Services;

namespace DateTimeRepository.Example
{
    public class Application : IApplication
    {
        private readonly IPointlessService _pointlessService;

        public Application(IPointlessService pointlessService)
        {
            _pointlessService = pointlessService;
        }

        public void Run() => _pointlessService.PointlessMethod(2);
    }

    #region

    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<PointlessService>().As<IPointlessService>();
            builder.RegisterType<DateTimeRepository>().As<IDateTimeRepository>();
            builder.RegisterType<DateTimeProvider>().As<IDateTimeProvider>();

            return builder.Build();
        }
    }

    public interface IApplication
    {
        void Run();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            DependencyProvider.ConfigureDependency(container.Resolve<IDateTimeProvider>());

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }

    #endregion
}

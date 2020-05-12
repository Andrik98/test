using Chronometer.Core.Time;
using Chronometer.Core.Time.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Chronometer.Core
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITimeDispatcher, TimeDispatcher>();
            services.AddSingleton<MainWindow>();
        }
    }
}

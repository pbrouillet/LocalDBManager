namespace LocalDBManager
{
    using System;
    using System.Windows.Forms;
    using Forms;
    using Microsoft.Extensions.DependencyInjection;

    static internal class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.ApplicationExit += (object? sender, EventArgs e) =>  {
            //    instancesManager?.Dispose();
            //};

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                using var notifyIconManager = serviceProvider.GetRequiredService<NotifyIconManager>();
                var mainForm = serviceProvider.GetRequiredService<MainForm>();

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging();
            services.AddScoped<MainForm>();
            services.AddScoped<NewInstanceForm>();
            services.AddScoped<IInstancesManager, InstancesManager>();
            services.AddSingleton<NotifyIconManager>();
        }
    }
}

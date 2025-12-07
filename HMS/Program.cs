using HMS.BLL.Services;
using HMS.DAL;
using HMS.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HMS.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<AppDbContext>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IUserService ,UserService>();

                    services.AddTransient<LoginForm>();
                    services.AddTransient<MainForm>();
                })
                .Build();

            ApplicationConfiguration.Initialize();

            var loginForm = host.Services.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}
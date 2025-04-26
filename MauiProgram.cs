using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace T2K_RestaurantManagement
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.Configuration.AddJsonFile(
                "appsettings.json",
                optional: false,
                reloadOnChange: true
            );

            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            builder.Services.AddMauiBlazorWebView();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "restaurant4.db");

            builder.Services.AddDbContextFactory<Models.T2KDBContext>(options =>
                options.UseSqlite($"Data Source={dbPath}")
            );

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            var app = builder.Build();

            var contextFactory = app.Services.GetRequiredService<IDbContextFactory<Models.T2KDBContext>>();
            using var context = contextFactory.CreateDbContext();

            context.Database.EnsureCreated();
            DBInitializer.Seed(context);

            return app;
        }
    }
}

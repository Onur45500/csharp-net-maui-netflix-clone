using CommunityToolkit.Maui;
using csharp_net_maui_netflix_clone.Pages;
using csharp_net_maui_netflix_clone.Services;
using Microsoft.Extensions.Logging;

namespace csharp_net_maui_netflix_clone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddHttpClient(TmdbService.TmdbHttpClientName,
                httpClient => httpClient.BaseAddress = new Uri("http://api.themoviedb.org"));

            builder.Services.AddSingleton<TmdbService>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}

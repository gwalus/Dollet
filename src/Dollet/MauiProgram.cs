using Dollet.ViewModels;
using Microsoft.Extensions.Logging;

namespace Dollet
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton((e) => Connectivity.Current);
            //builder.Services.AddSingleton<IToast>((e) => new Toaster());

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<DetailPageViewModel>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<DetailPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

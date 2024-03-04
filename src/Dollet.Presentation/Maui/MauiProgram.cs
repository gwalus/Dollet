using Dollet.ViewModels;
using Microsoft.Extensions.Logging;
using Dollet.Core;

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

            builder.Services.AddViewModels();
            builder.Services.AddPages();
            builder.Services.AddCore();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

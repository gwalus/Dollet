using CommunityToolkit.Maui;
using Dollet.Core;
using Dollet.Infrastructure;

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
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIconsRegular");
                })
                .UseMauiCommunityToolkit();

            builder.Services.AddSingleton((e) => Connectivity.Current);

            builder.Services.AddPresentation();
            builder.Services.AddCore();
            builder.Services.AddInfrastructure();

            return builder.Build();
        }
    }
}
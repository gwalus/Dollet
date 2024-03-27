using CommunityToolkit.Maui;
using Dollet.Core;
using Dollet.Handlers;
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
                    fonts.AddFont("VactorySans-Regular.ttf", "VactorySansRegular");
                    //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIconsRegular");
                })
                .UseMauiCommunityToolkit();
//                .ConfigureMauiHandlers(handlers => {
////#if ANDROID
//                           handlers.AddHandler(typeof(Shell), typeof(CustomShellHandler));
////#endif
//                }

//            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("MyPickerHandler", (handler, view) =>
//            {
//#if ANDROID
//                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
//#endif
//            });

            FormHandler.RemoveBorders();

            builder.Services.AddPresentation();
            builder.Services.AddCore();
            builder.Services.AddInfrastructure();

            DataSeeder.SeedAsync(builder.Services).GetAwaiter().GetResult();

            return builder.Build();
        }
    }
}
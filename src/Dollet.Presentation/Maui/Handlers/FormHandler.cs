using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Dollet.Handlers
{
    internal static class FormHandler
    {
        public static void RemoveBorders()
        {
            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.Background = null;
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
            });
        }
    }
}

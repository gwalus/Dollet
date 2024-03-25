namespace Dollet.Core.DAL.Helpers
{
    internal class DatabasePath
    {
        public static string GetPath(string databaseName)
        {
            string path = string.Empty;

            if(DeviceInfo.Platform == DevicePlatform.Android)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                path = Path.Combine(path, databaseName);

                return path;
            }

            return path;
        }
    }
}

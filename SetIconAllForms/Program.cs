using System.Reflection;

namespace SetIconAllForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SetDefaultIconAllForms();
            Application.Run(new FDemo());
        }

        private static void SetDefaultIconAllForms()
        {
            var field = typeof(Form).GetField("defaultIcon", BindingFlags.Static | BindingFlags.NonPublic);
            using (var iconStream = typeof(Program).Assembly.GetManifestResourceStream($"SetIconAllForms.windows2.ico"))
            {
                var ico = new Icon(iconStream);
                field?.SetValue(null, ico);
            }
        }
    }
}
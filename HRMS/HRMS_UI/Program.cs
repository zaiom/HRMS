namespace HRMS_UI
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

            // Inicjuj po³¹czenie z baz¹ danych
            HRMS_Lib.GlobalConfig.InitializeConnection();

            Application.Run(new DodajPracownikaForm());
        }
    }
}
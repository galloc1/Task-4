//SACE: 933898F, 9/03/2023
namespace School_Manager
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
            (new Start_Page()).Show();
            Application.Run();
        }
    }
}
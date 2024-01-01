

using HmrsDeneme.Entity;
using System.Data.Entity;

namespace HmrsDeneme
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

            Database.SetInitializer<HmrsContext>(new CreateDatabaseIfNotExists<HmrsContext>());

            Application.Run(new frmHmrsGiris());
        }
    }
}
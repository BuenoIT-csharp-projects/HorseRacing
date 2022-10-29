/*
 * 
 * File Name: Program.cs
 * Description: An interactive horse racing game with timestamps and general features
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.10.28: Created
 *      
 * 
*/

namespace HorseRacing
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
            Application.Run(new HorseRacingGame());
        }
    }
}
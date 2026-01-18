using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace TouhouGameLauncher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new LoadingForm());

            // GUI‹N“®
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new MainForm());
        }
    }
}
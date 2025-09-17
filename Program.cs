using System;
using System.Windows.Forms;

namespace EEMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enable modern styles for controls
            Application.SetCompatibleTextRenderingDefault(false); // Use GDI+ rendering
            Application.Run(new Form1()); // Start the app with Form1
        }
    }
}

// I know in the past I ripped code but that has changed.
// I don't expect you to appreciate my work or like me but I've made this fully from scratch with nothing but my knowledge of what I currently know.
// I understand if you rip the code as I was once in that position. Credit if you're able to, but feel free to have it for yourself.
// Thank you for reading.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Valenity.Forms;

namespace Valenity
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launch());
        }
    }
}
using Gtk;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CarpeDiem.DataTools.Workbench.Views;

namespace CarpeDiem.DataTools.Common
{
    public class GtkApplicationAdapter : IApplicationAdapter
    {
        [STAThread]
        public void Run(Lazy<IWorkbenchView> view)
        {
            Application.Init();

            // Gtk.Settings.Default.ThemeName = "MS-Windows";

            var app = new Application("org.DataTools.DataTools", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var mainWindow = (Window)view.Value;

            app.AddWindow(mainWindow);

            mainWindow.Show();

            Application.Run();
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
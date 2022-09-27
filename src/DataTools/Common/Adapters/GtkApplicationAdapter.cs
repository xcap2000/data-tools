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

namespace CarpeDiem.DataTools.Common.Adapters
{
    public class GtkApplicationAdapter : IApplicationAdapter
    {
        public void Run(Lazy<IWorkbenchView> view)
        {
            //Environment.SetEnvironmentVariable("GTK_THEME", "Adwaita:dark"); // works

            //Environment.SetEnvironmentVariable("GTK_THEME", "Windows10"); // works, theme on C:\\Users\\xcap2\\AppData\\Local\\Gtk\\3.24.31-x64\\share\\themes\\Windows10

            Application.Init();

            Settings.Default.ThemeName = "Windows10"; // works, theme on C:\\Users\\xcap2\\AppData\\Local\\Gtk\\3.24.31-x64\\share\\themes\\Windows10
            //Gtk.Settings.Default.ThemeName = "Millennium";

            // Partially works
            //Gtk.CssProvider cssProvider = new Gtk.CssProvider();
            //cssProvider.LoadFromPath("C:\\Users\\xcap2\\AppData\\Local\\Gtk\\3.24.31-x64\\share\\themes\\Windows10\\gtk-3.0\\gtk.css");
            //Gtk.StyleContext.AddProviderForScreen(Gdk.Screen.Default, cssProvider, 800);
            //Gtk.StyleContext.ResetWidgets(Gdk.Screen.Default);

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
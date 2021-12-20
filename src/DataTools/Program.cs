using System;
using Gtk;

namespace CarpeDiem.DataTools
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.Init();

            // Gtk.Settings.Default.ThemeName = "MS-Windows";

            var app = new Application("org.DataTools.DataTools", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}

using System;
using Gtk;

namespace DataTools
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.Init();

            var app = new Application("org.DataTools.DataTools", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}

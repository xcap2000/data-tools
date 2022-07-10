using System;
using Autofac;
using CarpeDiem.DataTools.Workbench.Views;
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

            var mainWindow = Resolve();

            app.AddWindow(mainWindow);

            mainWindow.Show();

            Application.Run();
        }

        public static Window Resolve()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataToolsModule>();

            var container = builder.Build();

            return (Window)container.Resolve<IWorkbenchView>();
        }
    }
}
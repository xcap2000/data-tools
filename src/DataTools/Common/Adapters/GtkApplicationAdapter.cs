using Gtk;
using System;
using System.IO.Compression;
using System.IO;
using System.Runtime.InteropServices;
using CarpeDiem.DataTools.Common.Views;

namespace CarpeDiem.DataTools.Common.Adapters;

public class GtkApplicationAdapter : IApplicationAdapter
{
    public void Run(Func<IView> getView)
    {
        SetupGtk();

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

        var mainWindow = (Window)getView();

        app.AddWindow(mainWindow);

        mainWindow.Show();

        Application.Run();
    }

    public void Quit()
    {
        Application.Quit();
    }

    private static void SetupGtk()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var stream = typeof(Program).Assembly.GetManifestResourceStream($"gtk-3.24.31-{bitness}.zip");
            var localAppData = Environment.GetEnvironmentVariable("LocalAppData");
            if (stream != null && localAppData != null)
            {
                var destinationDirectoryName = Path.Combine(localAppData, "Gtk", $"3.24.31-{bitness}");

                if (Directory.Exists(destinationDirectoryName))
                {
                    var shouldUpdate = Directory.GetCreationTime(destinationDirectoryName) <= System.DateTime.Parse("2022/03/25 00:00:00");
                    if (shouldUpdate)
                    {
                        Directory.Delete(destinationDirectoryName, true);
                    }
                }

                if (!Directory.Exists(destinationDirectoryName))
                {
                    using var zipArchive = new ZipArchive(stream, ZipArchiveMode.Read, false);
                    zipArchive.ExtractToDirectory(destinationDirectoryName);
                }
                Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + $";{destinationDirectoryName}");
            }
        }
    }
}
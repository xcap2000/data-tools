using System;
using System.IO.Compression;
using System.IO;
using System.Runtime.InteropServices;
using Autofac;
using CarpeDiem.DataTools.Workbench.Views;
using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Enums;

namespace CarpeDiem.DataTools
{
    public static class Program
    {
        private static readonly ContainerBuilder builder = new ContainerBuilder();
        private static IContainer container = default!;

        [STAThread]
        public static void Main(string[] args)
        {
            //var ui = args.Length > 0 && args[0] == "wf" ? Ui.WinForms : Ui.Gtk;
            var ui = Ui.WinForms;

            if (ui == Ui.Gtk)
            {
                SetupGtk();
            }

            builder.RegisterModule(new DataToolsModule(ui));

            container = builder.Build();

            var application = container.Resolve<IApplicationAdapter>();
            var view = container.Resolve<Lazy<IWorkbenchView>>();

            application.Run(view);
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
                        zipArchive.ExtractToDirectory(destinationDirectoryName, false);
                    }
                    Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + $";{destinationDirectoryName}");
                    //Environment.SetEnvironmentVariable("GTK_PATH", Environment.GetEnvironmentVariable("PATH") + $";{destinationDirectoryName}");
                }
            }
        }
    }
}
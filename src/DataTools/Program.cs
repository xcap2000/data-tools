using System;
using Autofac;
using CarpeDiem.DataTools.Workbench.Views;
using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Enums;

namespace CarpeDiem.DataTools
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var ui = args.Length > 0 && args[0] == "wf" ? Ui.WinForms : Ui.Gtk;
            //var ui = Ui.WinForms;

            var container = GetContainer(ui);
            var application = container.Resolve<IApplicationAdapter>();
            var getView = () => container.Resolve<IWorkbenchView>();

            application.Run(getView);
        }

        public static IContainer GetContainer(Ui ui)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DataToolsModule(ui));
            return builder.Build();
        }
    }
}
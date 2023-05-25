using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Tasks.Contexts;
using CarpeDiem.DataTools.Workbench.Views;

namespace CarpeDiem.DataTools;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var container = GetContainer();

        var context = container.Resolve<ITasksContext>();
        context.InitializeDatabase();

        var application = container.Resolve<IApplicationAdapter>();
        application.Run(() => container.Resolve<IWorkbenchView>());
    }

    public static IContainer GetContainer()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<DataToolsModule>();
        return builder.Build();
    }
}
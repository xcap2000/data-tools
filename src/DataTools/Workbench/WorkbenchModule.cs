using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using CarpeDiem.DataTools.Workbench.Views;

namespace CarpeDiem.DataTools.Workbench;

public class WorkbenchModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule<ViewsModule>();
    }
}
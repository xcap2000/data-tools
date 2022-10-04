using Autofac;
using CarpeDiem.DataTools.Common.Enums;
using CarpeDiem.DataTools.Workbench.Commands;
using CarpeDiem.DataTools.Workbench.Presenters;
using CarpeDiem.DataTools.Workbench.Views;

namespace CarpeDiem.DataTools.Workbench;

public class WorkbenchModule : Module
{
    private readonly Ui ui;

    public WorkbenchModule(Ui ui)
    {
        this.ui = ui;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule(new ViewsModule(ui));
    }
}
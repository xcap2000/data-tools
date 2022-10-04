using Autofac;
using CarpeDiem.DataTools.Calculator;
using CarpeDiem.DataTools.Common;
using CarpeDiem.DataTools.Common.Enums;
using CarpeDiem.DataTools.Workbench;
using Prism.Events;

namespace CarpeDiem.DataTools;

public class DataToolsModule : Module
{
    private readonly Ui ui;

    public DataToolsModule(Ui ui)
    {
        this.ui = ui;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule(new CommonModule(ui));
        builder.RegisterModule(new WorkbenchModule(ui));
        builder
            .RegisterType<EventAggregator>()
            .As<IEventAggregator>()
            .SingleInstance();
        builder.RegisterModule(new CaulculatorModule(ui));
    }
}
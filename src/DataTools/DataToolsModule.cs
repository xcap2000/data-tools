using Autofac;
using CarpeDiem.DataTools.Calculator;
using CarpeDiem.DataTools.Common;
using CarpeDiem.DataTools.Workbench;
using Prism.Events;

namespace CarpeDiem.DataTools;

public class DataToolsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommonModule>();
        builder.RegisterModule<WorkbenchModule>();
        builder
            .RegisterType<EventAggregator>()
            .As<IEventAggregator>()
            .SingleInstance();
        builder.RegisterModule<CalculatorModule>();
    }
}
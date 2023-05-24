using CarpeDiem.DataTools.Calculator;
using CarpeDiem.DataTools.Common;
using CarpeDiem.DataTools.Tasks;
using CarpeDiem.DataTools.Workbench;
using Prism.Events;

namespace CarpeDiem.DataTools;

public class DataToolsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommonModule>();
        builder.RegisterModule<WorkbenchModule>();
        builder.RegisterModule<CalculatorModule>();
        builder.RegisterModule<TasksModule>();
        builder
            .RegisterType<EventAggregator>()
            .As<IEventAggregator>()
            .SingleInstance();
    }
}
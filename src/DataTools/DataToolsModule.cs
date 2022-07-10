using Autofac;
using CarpeDiem.DataTools.Calculator;
using CarpeDiem.DataTools.Workbench;

namespace CarpeDiem.DataTools;

public class DataToolsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CaulculatorModule>();
        builder.RegisterModule<WorkbenchModule>();
    }
}
using CarpeDiem.DataTools.Workbench.Commands;

namespace CarpeDiem.DataTools.Calculator.Commands;

public class CommandsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculateCommand>()
            .As<IWorkbenchCommand>()
            .SingleInstance()
            .PreserveExistingDefaults();
    }
}
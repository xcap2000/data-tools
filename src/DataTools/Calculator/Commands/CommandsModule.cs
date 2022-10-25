using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Calculator.Commands;

public class CommandsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CalculateCommand>()
            .As<ICommand>()
            .SingleInstance()
            .PreserveExistingDefaults();
    }
}
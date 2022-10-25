using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CommandsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CloseCommand>()
            .As<ICommand>()
            .SingleInstance()
            .PreserveExistingDefaults();
    }
}
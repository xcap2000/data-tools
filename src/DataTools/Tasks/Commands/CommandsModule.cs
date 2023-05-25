using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Tasks.Commands;

public class CommandsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<TasksCommand>()
            .As<ICommand>()
            .SingleInstance()
            .PreserveExistingDefaults();
    }
}
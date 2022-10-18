namespace CarpeDiem.DataTools.Workbench.Commands;

public class CommandsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<CloseCommand>()
            .As<IWorkbenchCommand>()
            .SingleInstance()
            .PreserveExistingDefaults();
    }
}
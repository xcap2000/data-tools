namespace CarpeDiem.DataTools.Workbench.Views;

public class ViewsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<WorkbenchView>()
            .As<IWorkbenchView>()
            .SingleInstance();
    }
}
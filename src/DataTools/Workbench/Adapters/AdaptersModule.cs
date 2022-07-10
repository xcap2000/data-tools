using Autofac;

namespace CarpeDiem.DataTools.Workbench.Adapters;

public class AdaptersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<ApplicationAdapter>()
            .As<IApplicationAdapter>()
            .SingleInstance();
    }
}
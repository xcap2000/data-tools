using Autofac;
using CarpeDiem.DataTools.Common.Adapters;

namespace CarpeDiem.DataTools.Common;

public class CommonModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<ApplicationAdapter>()
            .As<IApplicationAdapter>()
            .SingleInstance();
    }
}
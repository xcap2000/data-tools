using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Resolvers;
using JiraIntegration.Common.Factories;

namespace CarpeDiem.DataTools.Common;

public class CommonModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<AdaptersModule>();
        builder.RegisterModule<FactoriesModule>();
        builder.RegisterModule<ResolversModule>();
        builder
            .RegisterGeneric(typeof(List<>))
            .As(typeof(IList<>))
            .UsingConstructor()
            .InstancePerDependency();
    }
}
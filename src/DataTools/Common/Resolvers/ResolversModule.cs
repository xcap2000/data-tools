using Autofac;

namespace CarpeDiem.DataTools.Common.Resolvers;

public class ResolversModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterGeneric(typeof(Resolver<>))
            .As(typeof(IResolver<>))
            .SingleInstance();
    }
}
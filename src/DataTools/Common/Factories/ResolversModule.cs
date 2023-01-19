using CarpeDiem.DataTools.Common.Factories;

namespace JiraIntegration.Common.Factories
{
    public class FactoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterGeneric(typeof(ListFactory<>))
                .As(typeof(IListFactory<>))
                .SingleInstance();
        }
    }
}
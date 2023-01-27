using CarpeDiem.DataTools.Common.Factories;
using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Unit.Common.Factories;

public static partial class BaseFactoryFacts
{
    public abstract class BaseFacts<T, TFactory>
        where T : class
        where TFactory : IFactory<T>
    {
        protected readonly IResolver<T> resolver;
        protected readonly TFactory factory;

        protected BaseFacts()
        {
            resolver = For<IResolver<T>>();
            factory = CreateFactory();
        }

        protected abstract TFactory CreateFactory();
    }
}
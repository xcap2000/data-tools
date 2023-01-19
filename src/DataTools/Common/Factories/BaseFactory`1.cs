using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Common.Factories;

public abstract class BaseFactory<T> : IFactory<T>
    where T : class
{
    private readonly IResolver<T> resolver;

    protected BaseFactory(IResolver<T> resolver)
        => this.resolver = resolver;

    public T Create()
        => resolver.Resolve();
}
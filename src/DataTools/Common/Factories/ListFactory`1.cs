using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Common.Factories;

public class ListFactory<T> : BaseFactory<IList<T>>, IListFactory<T>
    where T : class
{
    public ListFactory(IResolver<IList<T>> resolver)
        : base(resolver)
    {
    }
}
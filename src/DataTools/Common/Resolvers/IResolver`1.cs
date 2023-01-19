namespace CarpeDiem.DataTools.Common.Resolvers;

public interface IResolver<T>
    where T : notnull
{
    T Resolve();

    T Resolve(params object[] arguments);
}
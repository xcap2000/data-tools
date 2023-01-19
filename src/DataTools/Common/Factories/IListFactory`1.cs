namespace CarpeDiem.DataTools.Common.Factories;

public interface IListFactory<T> : IFactory<IList<T>>
    where T : class
{
}
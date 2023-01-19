namespace CarpeDiem.DataTools.Common.Factories;

public interface IFactory<T>
    where T : class
{
    T Create();
}
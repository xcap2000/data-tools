using CarpeDiem.DataTools.Common.Factories;

namespace CarpeDiem.DataTools.Unit.Common.Factories;

public abstract class BaseTheCreateMethod<T, TFactory> : BaseFacts<T, TFactory>
    where T : class
    where TFactory : IFactory<T>
{
    [Fact]
    public void ResolvesInstance()
    {
        // Given
        var expectedView = For<T>();
        resolver.Resolve().Returns(expectedView);

        // When
        var actualView = factory.Create();

        // Then
        Same(expectedView, actualView);
    }
}
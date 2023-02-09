using CarpeDiem.DataTools.Common;

namespace CarpeDiem.DataTools.Calculator;

public class CalculatorFixture : IDisposable
{
    private bool disposed;

    public CalculatorFixture()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<CommonModule>();
        builder.RegisterModule<CalculatorModule>();
        Container = builder.Build();
    }

    public IContainer Container { get; }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
        {
            Container.Dispose();
        }

        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
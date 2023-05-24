using CarpeDiem.DataTools.Common;
using CarpeDiem.DataTools.Tasks.Contexts;

namespace CarpeDiem.DataTools.Tasks.Services;

public class TasksFixture : IDisposable
{
    private bool disposed;

    public TasksFixture()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<CommonModule>();
        builder.RegisterModule<TasksModule>();
        builder.RegisterInstance(For<ITasksContext>());
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
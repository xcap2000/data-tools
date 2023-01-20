using System;
using CarpeDiem.DataTools.Common.Contexts;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks;

public class TasksFixture : IDisposable
{
    private bool disposed;

    public TasksFixture()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<TasksModule>();
        builder.RegisterInstance(For<IContext>());
        builder.RegisterInstance(For<ITasksView>());
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
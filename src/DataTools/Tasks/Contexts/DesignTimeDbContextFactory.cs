using CarpeDiem.DataTools.Tasks.Contexts;
using Microsoft.EntityFrameworkCore.Design;

namespace CarpeDiem.DataTools.Common.Contexts;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TasksContext>
{
    public TasksContext CreateDbContext(string[] args)
    {
        var container = GetContainer();
        return container.Resolve<TasksContext>();
    }

    public static IContainer GetContainer()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule<ContextsModule>();
        return builder.Build();
    }
}
using Autofac;
using CarpeDiem.DataTools.Tasks.Presenters;
using CarpeDiem.DataTools.Tasks.Repositories;
using CarpeDiem.DataTools.Tasks.Services;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks;

public class TasksModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterModule<PresentersModule>()
            .RegisterModule<RepositoriesModule>()
            .RegisterModule<ServicesModule>()
            .RegisterModule<ViewsModule>();
    }
}
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
            // builder.RegisterModule<CommandsModule>();
            // builder.RegisterModule<FactoriesModule>();
            // builder.RegisterModule<MappersModule>();
            // builder.RegisterModule<ModelsModule>();
            .RegisterModule<PresentersModule>()
            .RegisterModule<RepositoriesModule>()
            // builder.RegisterModule<RequestsModule>();
            // builder.RegisterModule<ResponsesModule>();
            .RegisterModule<ServicesModule>()
            .RegisterModule<ViewsModule>();
    }
}
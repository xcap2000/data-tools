using CarpeDiem.DataTools.Tasks.Mappers;
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
            // .RegisterModule<CommandsModule>()
            // .RegisterModule<FactoriesModule>()
            .RegisterModule<MappersModule>()
            // .RegisterModule<ModelsModule>()
            .RegisterModule<PresentersModule>()
            .RegisterModule<RepositoriesModule>()
            // .RegisterModule<RequestsModule>()
            // .RegisterModule<ResponsesModule>()
            .RegisterModule<ServicesModule>()
            .RegisterModule<ViewsModule>();
    }
}
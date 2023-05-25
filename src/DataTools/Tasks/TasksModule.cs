using CarpeDiem.DataTools.Tasks.Commands;
using CarpeDiem.DataTools.Tasks.Contexts;
using CarpeDiem.DataTools.Tasks.Factories;
using CarpeDiem.DataTools.Tasks.Mappers;
using CarpeDiem.DataTools.Tasks.Models;
using CarpeDiem.DataTools.Tasks.Presenters;
using CarpeDiem.DataTools.Tasks.Repositories;
using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;
using CarpeDiem.DataTools.Tasks.Services;
using CarpeDiem.DataTools.Tasks.Views;

namespace CarpeDiem.DataTools.Tasks;

public class TasksModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterModule<ContextsModule>()
            .RegisterModule<CommandsModule>()
            .RegisterModule<FactoriesModule>()
            .RegisterModule<MappersModule>()
            .RegisterModule<ModelsModule>()
            .RegisterModule<PresentersModule>()
            .RegisterModule<RepositoriesModule>()
            .RegisterModule<RequestsModule>()
            .RegisterModule<ResponsesModule>()
            .RegisterModule<ServicesModule>()
            .RegisterModule<ViewsModule>();
    }
}
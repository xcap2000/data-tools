using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Calculator.Mappers;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Presenters;
using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Calculator.Responses;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator;

public class CalculatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<FactoriesModule>();
        builder.RegisterModule<MappersModule>();
        builder.RegisterModule<ModelsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule<RequestsModule>();
        builder.RegisterModule<ResponsesModule>();
        builder.RegisterModule<ServicesModule>();
        builder.RegisterModule<ViewsModule>();
    }
}
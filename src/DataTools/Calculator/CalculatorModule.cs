using Autofac;
using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Presenters;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator;

public class CalculatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<ModelsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule<ServicesModule>();
        builder.RegisterModule<ViewsModule>();
    }
}
using Autofac;
using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Calculator.Presenters;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator;

public class CaulculatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule<ServicesModule>();
        builder.RegisterModule<ViewsModule>();
    }
}
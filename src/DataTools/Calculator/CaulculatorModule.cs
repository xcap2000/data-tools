using Autofac;
using CarpeDiem.DataTools.Calculator.Commands;
using CarpeDiem.DataTools.Calculator.Presenters;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;
using CarpeDiem.DataTools.Common.Enums;

namespace CarpeDiem.DataTools.Calculator;

public class CaulculatorModule : Module
{
    private readonly Ui ui;

    public CaulculatorModule(Ui ui)
    {
        this.ui = ui;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<CommandsModule>();
        builder.RegisterModule<PresentersModule>();
        builder.RegisterModule<ServicesModule>();
        builder.RegisterModule(new ViewsModule(ui));
    }
}
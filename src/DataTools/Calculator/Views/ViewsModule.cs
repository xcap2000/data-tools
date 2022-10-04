using Autofac;
using CarpeDiem.DataTools.Common.Enums;

namespace CarpeDiem.DataTools.Calculator.Views;

public class ViewsModule : Module
{
    private readonly Ui ui;

    public ViewsModule(Ui ui)
    {
        this.ui = ui;
    }

    protected override void Load(ContainerBuilder builder)
    {
        switch (ui)
        {
            case Ui.WinForms:
                builder
                    .RegisterType<WinFormsMiniCalcView>()
                    .As<IMiniCalcView>()
                    .SingleInstance();
                break;
            case Ui.Gtk:
                builder
                    .RegisterType<MiniCalcView>()
                    .As<IMiniCalcView>()
                    .SingleInstance();
                break;
        }
    }
}
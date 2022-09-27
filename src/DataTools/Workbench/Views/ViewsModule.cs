using Autofac;
using CarpeDiem.DataTools.Common.Enums;

namespace CarpeDiem.DataTools.Workbench.Views;

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
                    .RegisterType<WinFormsWorkbenchView>()
                    .As<IWorkbenchView>()
                    .SingleInstance();
                break;
            case Ui.Gtk:
                builder
                    .RegisterType<WorkbenchView>()
                    .As<IWorkbenchView>()
                    .SingleInstance();
                break;
        }
    }
}
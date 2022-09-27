using Autofac;
using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Enums;
using CarpeDiem.DataTools.Workbench.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpeDiem.DataTools.Common
{
    public class CommonModule : Module
    {
        private readonly Ui ui;

        public CommonModule(Ui ui)
        {
            this.ui = ui;
        }

        protected override void Load(ContainerBuilder builder)
        {
            switch (ui)
            {
                case Ui.WinForms:
                    builder
                        .RegisterType<WinFormsApplicationAdapter>()
                        .As<IApplicationAdapter>()
                        .SingleInstance();
                    break;
                case Ui.Gtk:
                    builder
                        .RegisterType<GtkApplicationAdapter>()
                        .As<IApplicationAdapter>()
                        .SingleInstance();
                    break;
            }
        }
    }
}
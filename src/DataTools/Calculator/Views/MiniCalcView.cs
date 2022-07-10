using System;
using CarpeDiem.DataTools.Calculator.Presenters;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace CarpeDiem.DataTools.Calculator.Views
{
    public class MiniCalcView : Box, IMiniCalcView
    {
        [UI]
        private readonly Entry? value1Entry = null;

        [UI]
        private readonly Entry? value2Entry = null;

        [UI]
        private readonly Label? resultLabel = null;
        private readonly IMiniCalcPresenter presenter;

        public MiniCalcView(IMiniCalcPresenter presenter)
            : this(new Builder("MiniCalcView.glade"))
        {
            this.presenter = presenter;
            Shown += MiniCalcView_Shown;
        }

        private MiniCalcView(Builder builder)
            : base(builder.GetRawOwnedObject("MiniCalcView"))
        {
            builder.Autoconnect(this);
        }

        public string Value1
        {
            get => value1Entry!.Text;
            set => value1Entry!.Text = value;
        }
        public string Value2
        {
            get => value2Entry!.Text;
            set => value2Entry!.Text = value;
        }
        public string Result { set => resultLabel!.Text = value; }

        private void MiniCalcView_Shown(object? sender, EventArgs a)
        {
            presenter.Initialize();
        }
    }
}

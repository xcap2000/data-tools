using System;
using CarpeDiem.DataTools.Greeting.Presenters;
using CarpeDiem.DataTools.Greeting.View;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace CarpeDiem.DataTools.Calculator.Views
{
    public class GreetingsView : Box, IGreetingsView
    {
        [UI] private readonly Entry firstNameEntry = null!;
        [UI] private readonly Entry middleNameEntry = null!;
        [UI] private readonly Entry lastNameEntry = null!;
        [UI] private readonly Label greetingMessageLabel = null!;
        [UI] private readonly Button greetButton = null!;

        private readonly IGreetingsPresenter presenter;

        public GreetingsView(IGreetingsPresenter presenter)
            : this(new Builder(nameof(MiniCalcView) + ".glade"), presenter)
        {
            firstNameEntry.Changed += FirstNameEntry_Changed;
            middleNameEntry.Changed += MiddleNameEntry_Changed;
            lastNameEntry.Changed += LastNameEntry_Changed;
            greetButton.Clicked += GreetButton_Clicked;
        }

        private GreetingsView(Builder builder, IGreetingsPresenter presenter)
            : base(builder.GetRawOwnedObject(nameof(MiniCalcView)))
        {
            builder.Autoconnect(this);
            this.presenter = presenter;
        }

        public string Message { set => greetingMessageLabel.Text = value; }

        private void FirstNameEntry_Changed(object? sender, EventArgs a)
        {
            presenter.OnFirstNameChanged(firstNameEntry.Text);
        }

        private void MiddleNameEntry_Changed(object? sender, EventArgs a)
        {
            presenter.OnMiddleNameChanged(middleNameEntry.Text);
        }

        private void LastNameEntry_Changed(object? sender, EventArgs a)
        {
            presenter.OnLastNameChanged(middleNameEntry.Text);
        }

        private void GreetButton_Clicked(object? sender, EventArgs a)
        {
            presenter.Greet();
        }
    }
}
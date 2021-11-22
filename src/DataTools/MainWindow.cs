using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace DataTools
{
    public class MainWindow : Window
    {
        [UI]
        private readonly Label? greetingLabel = null;
        [UI]
        private readonly Button? clickMeButton = null;

        private int counter;

        public MainWindow()
            : this(new Builder("MainWindow.glade"))
        {
        }

        private MainWindow(Builder builder)
            : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            clickMeButton!.Clicked += Button1_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object? sender, EventArgs a)
        {
            counter++;
            greetingLabel!.Text = "Hello World! This button has been clicked " + counter + " time(s).";
        }
    }
}

using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;
using Gtk;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public class WorkbenchView : Window, IWorkbenchView
    {
        [Builder.Object]
        private readonly MenuBar? menuBar = null;

        public WorkbenchView()
            : this(new Builder("WorkbenchView.glade"))
        {
        }

        private WorkbenchView(Builder builder)
            : base(builder.GetRawOwnedObject("WorkbenchView"))
        {
            builder.Autoconnect(this);
        }

        public IEnumerable<IWorkbenchCommand> Commands
        {
            set
            {
                foreach (var command in value)
                {
                    var menuItem = new MenuItem("Close");
                    menuBar.Add(menuItem);
                }
            }
        }
    }
}
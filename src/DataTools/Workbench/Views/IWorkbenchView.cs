using System.Collections.Generic;
using CarpeDiem.DataTools.Common.Views;
using CarpeDiem.DataTools.Workbench.Commands;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public interface IWorkbenchView : IView
    {
        IEnumerable<IWorkbenchCommand> Commands { set; }

        // TODO - Test.
        void Activate(object o);
    }
}
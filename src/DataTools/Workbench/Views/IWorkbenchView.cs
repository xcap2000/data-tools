using CarpeDiem.DataTools.Common.Commands;
using CarpeDiem.DataTools.Common.Views;

namespace CarpeDiem.DataTools.Workbench.Views;

public interface IWorkbenchView : IView
{
    IEnumerable<ICommand> Commands { set; }

    // TODO - Test.
    void Activate(object o);
}
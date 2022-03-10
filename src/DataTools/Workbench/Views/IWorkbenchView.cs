using System.Collections.Generic;
using CarpeDiem.DataTools.Workbench.Commands;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public interface IWorkbenchView
    {
        IEnumerable<IWorkbenchCommand> Commands { set; }
    }
}
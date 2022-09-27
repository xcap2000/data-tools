using CarpeDiem.DataTools.Workbench.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpeDiem.DataTools.Common.Adapters
{
    public interface IApplicationAdapter
    {
        // TODO - Configure container to accept (IView view), make IWorkbenchView a lazy object itself like the presenter (LazyWorkbenchPresenter).
        void Run(Lazy<IWorkbenchView> view);

        void Quit();
    }
}
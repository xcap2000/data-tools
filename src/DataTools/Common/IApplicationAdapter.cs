using CarpeDiem.DataTools.Workbench.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpeDiem.DataTools.Common
{
    public interface IApplicationAdapter
    {
        void Run(Lazy<IWorkbenchView> view);

        void Quit();
    }
}